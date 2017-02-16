using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.IO;

using Perrich.SepaWriter;
namespace Christopher.Schenk.SepaBeitragsGenerator
{
    public partial class frmMain : Form
    {
        public static double ToDouble(string In)
        {
            In = In.Replace(",", ".");

            return double.Parse(In, System.Globalization.CultureInfo.InvariantCulture);
        }

        private const string REGEX_PATTERN = @"([^A-Za-z0-9-+:'?, ()+./])";
        private List<Column> availableColumns;
        public frmMain()
        {
            InitializeComponent();
            availableColumns = new List<Column>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int skipped = 0;
            pBar.MarqueeAnimationSpeed = 25;
            pBar.Visible = true;
            if (txtSource.Text.Equals("") | txtTarget.Text.Equals("") | txtCreditorBic.Text.Equals("") | txtCreditorID.Text.Equals("") | txtCreditorIBAN.Text.Equals("") | txtCreditorName.Text.Equals("") | cbDebtIBAN.SelectedIndex < 0 | cbDebtName1.SelectedIndex < 0 | (rbVariableAmount.Checked && cbAmount.SelectedIndex < 0) | txtUsage.Text.Equals(""))
            {
                pBar.MarqueeAnimationSpeed = 0;
                MessageBox.Show("Bitte überprüfen Sie ihre Eingaben!");
                return;
            }
            else if (!System.IO.File.Exists(txtSource.Text))
            {
                pBar.MarqueeAnimationSpeed = 0;
                MessageBox.Show("Auf die Quell-datei konnte nicht zugegriffen werden!");
                return;
            }
            try
            {
                SepaDebitTransfer transfer = new SepaDebitTransfer();

                SepaIbanData creditor = new SepaIbanData();
                creditor.Bic = txtCreditorBic.Text;
                creditor.Iban = txtCreditorIBAN.Text;
                creditor.Name = NormalizeString(txtCreditorName.Text);

                transfer.Creditor = creditor;
                transfer.PersonId = txtCreditorID.Text;
                transfer.MessageIdentification = dtDate.Value.Year.ToString() + dtDate.Value.Month.ToString() + dtDate.Value.Day.ToString() + "-" + txtCreditorName.Text;
                transfer.InitiatingPartyName = txtCreditorName.Text;
                transfer.RequestedExecutionDate = dtDate.Value;



                StreamReader _sr = new StreamReader(txtSource.Text);
                string line = _sr.ReadLine(); 
                if(columnHeaders.Checked)
                    line = _sr.ReadLine(); //Remove first line if there are headings
                List<string> skippedCreditors = new List<string>();
                while (line != null)
                {

                    line = line.Replace("\"", "");
                    string[] debitorData = line.Split(';');
                    string name = "";
                    if (!debitorData[((Column)cbDebtIBAN.SelectedItem).Index].Equals("") && !debitorData[((Column)cbDebtName1.SelectedItem).Index].Equals("") && !debitorData[((Column)cbDebtIBAN.SelectedItem).Index].Equals(""))
                    {
                        SepaDebitTransferTransaction transaction = new SepaDebitTransferTransaction();
                        SepaIbanData debtor = new SepaIbanData();
                        debtor.Bic = debitorData[((Column)cbDebtBIC.SelectedItem).Index];
                        debtor.Iban = debitorData[((Column)cbDebtIBAN.SelectedItem).Index];
                        if(cbDebtName2.SelectedIndex < 0)
                            name = debitorData[((Column)cbDebtName1.SelectedItem).Index];
                        else
                            name = debitorData[((Column)cbDebtName1.SelectedItem).Index] + " " + debitorData[((Column)cbDebtName2.SelectedItem).Index];
                        debtor.Name = Regex.Replace(NormalizeString(name), REGEX_PATTERN, String.Empty);
                        if (!debtor.IsValid)
                        {
                            skippedCreditors.Add(debtor.Name);
                        }
                        else
                        {

                            transaction.Debtor = debtor;
                            transaction.MandateIdentification = Regex.Replace(NormalizeString(ReplaceWithColumnValues(txtReference.Text, debitorData)).Replace(" ", ""), REGEX_PATTERN, String.Empty);
                            transaction.RemittanceInformation = Regex.Replace(NormalizeString(ReplaceWithColumnValues(txtUsage.Text, debitorData)), REGEX_PATTERN, String.Empty);
                            if(cbDtOfSgntr.SelectedIndex >= 0)
                                transaction.DateOfSignature = DateTime.Parse(debitorData[((Column)cbDtOfSgntr.SelectedItem).Index]);
                            if (rbFixedAmount.Checked)
                            {
                                transaction.Amount = numAmount.Value;
                            }
                            else if (rbVariableAmount.Checked)
                            {
                                transaction.Amount = (Decimal)ToDouble(debitorData[((Column)cbAmount.SelectedItem).Index]);
                            }
                            transfer.AddDebitTransfer(transaction);
                        }
                    }
                    else
                    {
                        skippedCreditors.Add(name);
                        skipped++;
                    }
                    line = _sr.ReadLine();
                }
                using (StreamWriter sw = new StreamWriter(new FileStream(txtTarget.Text, FileMode.Create), new System.Text.UTF8Encoding(false)))
                {
                    sw.Write(transfer.AsXmlString());
                }
                if (skippedCreditors.Count > 0)
                {
                    CreateErrorReport(skippedCreditors, txtTarget.Text + ".ErrorReport.txt");
                    MessageBox.Show("Es wurde erfolgreich eine SEPA-Datei erstellt! Dabei wurden jedoch " + skippedCreditors.Count.ToString() + " Datensätze übersprungen!\r\nEine Reportdatei wurde unter folgenden Pfad erstellt:\r\n" + txtTarget.Text + ".ErrorReport.txt", "Erfolgreich mit Warnungen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Es wurde erfolgreich eine SEPA-Datei erstellt!", "Erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception exc)
            {
                if (File.Exists(txtTarget.Text))
                    System.IO.File.Delete(txtTarget.Text);
                MessageBox.Show("Fehler: \r\n" + exc.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pBar.MarqueeAnimationSpeed = 0;
                pBar.Visible = false;
                MessageBox.Show("Fertig!\r\n Es wurden " + skipped.ToString() + " Datensätz übersprungen!");
            }
        }

        string NormalizeString(string input)
        {
            return input.Replace("ä", "ae").Replace("Ä", "Ae").Replace("ö", "oe").Replace("Ö", "oe").Replace("ü", "ue").Replace("Ü", "Ue").Replace("-", " ").Replace("_", " ").Replace("ß", "ss");
        }

        string ReplaceWithColumnValues(string text, string[] row)
        {
            string returnValue = text;
            foreach(Column column in availableColumns)
            {
                returnValue = returnValue.Replace("<<" + column.Name + ">>", row[column.Index]);
            }
            return returnValue;
        }

        private void CreateErrorReport(List<string> failedMitglieder, string filename)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
            sw.WriteLine("Folgende Mitglieder haben keine Gültigen Konto Daten:\r\n");
            foreach (string s in failedMitglieder)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            sw.Dispose();
        }

        private void btnSearchSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV-Dateien|*.csv";
            ofd.ShowDialog();
            txtSource.Text = ofd.FileName;
        }

        private void btnZiel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML-Dateien|*.xml";
            sfd.ShowDialog();
            txtTarget.Text = sfd.FileName;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string header;
            char column = 'A';
            using (StreamReader sr = new StreamReader(txtSource.Text))
                header = sr.ReadLine();
            string[] headers = header.Split(';');
            for (int i = 0; i < headers.Length; i++)
                if (columnHeaders.Checked)
                    availableColumns.Add(new Column() { Index = i, Name = headers[i] });
                else
                    availableColumns.Add(new Column { Index = i, Name = "Spalte " + (column + i) });
            cbDebtName1.Items.AddRange(availableColumns.ToArray());
            cbDebtName2.Items.AddRange(availableColumns.ToArray());
            cbDebtIBAN.Items.AddRange(availableColumns.ToArray());
            cbDebtBIC.Items.AddRange(availableColumns.ToArray());
            cbAmount.Items.AddRange(availableColumns.ToArray());
            cbAddToUsageText.Items.AddRange(availableColumns.ToArray());
            cbAddToReferenceText.Items.AddRange(availableColumns.ToArray());
            cbDtOfSgntr.Items.AddRange(availableColumns.ToArray());
            targetBox.Enabled = true;
            debtorBox.Enabled = true;
            creditorBox.Enabled = true;
        }

        private void btnPasteReference_Click(object sender, EventArgs e)
        {
            if(cbAddToReferenceText.SelectedIndex >= 0)
            {
                txtReference.Paste("<<" + ((Column)cbAddToReferenceText.SelectedItem).Name + ">>");
                cbAddToReferenceText.SelectedIndex = -1;
            }
        }

        private void btnPasteUsage_Click(object sender, EventArgs e)
        {
            if (cbAddToUsageText.SelectedIndex >= 0)
            {
                txtUsage.Paste("<<" + ((Column)cbAddToUsageText.SelectedItem).Name + ">>");
                cbAddToUsageText.SelectedIndex = -1;
            }
        }
    }
}
