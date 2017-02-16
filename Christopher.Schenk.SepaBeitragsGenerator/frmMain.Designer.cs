namespace Christopher.Schenk.SepaBeitragsGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreditorName = new System.Windows.Forms.TextBox();
            this.txtCreditorIBAN = new System.Windows.Forms.TextBox();
            this.txtCreditorBic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSearchSource = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnSearchTarget = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.debtorBox = new System.Windows.Forms.GroupBox();
            this.btnPasteReference = new System.Windows.Forms.Button();
            this.cbAddToReferenceText = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.btnPasteUsage = new System.Windows.Forms.Button();
            this.cbAddToUsageText = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.cbAmount = new System.Windows.Forms.ComboBox();
            this.rbFixedAmount = new System.Windows.Forms.RadioButton();
            this.rbVariableAmount = new System.Windows.Forms.RadioButton();
            this.cbDebtBIC = new System.Windows.Forms.ComboBox();
            this.cbDebtIBAN = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDebtName1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreditorID = new System.Windows.Forms.TextBox();
            this.columnHeaders = new System.Windows.Forms.CheckBox();
            this.cbDebtName2 = new System.Windows.Forms.ComboBox();
            this.creditorBox = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.targetBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDtOfSgntr = new System.Windows.Forms.ComboBox();
            this.debtorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.creditorBox.SuspendLayout();
            this.targetBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gläubiger Identifikations ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gläubiger Name:";
            // 
            // txtCreditorName
            // 
            this.txtCreditorName.Location = new System.Drawing.Point(149, 51);
            this.txtCreditorName.Name = "txtCreditorName";
            this.txtCreditorName.Size = new System.Drawing.Size(100, 20);
            this.txtCreditorName.TabIndex = 7;
            // 
            // txtCreditorIBAN
            // 
            this.txtCreditorIBAN.Location = new System.Drawing.Point(149, 77);
            this.txtCreditorIBAN.Name = "txtCreditorIBAN";
            this.txtCreditorIBAN.Size = new System.Drawing.Size(100, 20);
            this.txtCreditorIBAN.TabIndex = 8;
            // 
            // txtCreditorBic
            // 
            this.txtCreditorBic.Location = new System.Drawing.Point(149, 103);
            this.txtCreditorBic.Name = "txtCreditorBic";
            this.txtCreditorBic.Size = new System.Drawing.Size(100, 20);
            this.txtCreditorBic.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gläubiger IBAN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gläubiger BIC:";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd.mm.yyyy";
            this.dtDate.Location = new System.Drawing.Point(149, 19);
            this.dtDate.MinDate = new System.DateTime(2014, 10, 8, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(196, 20);
            this.dtDate.TabIndex = 12;
            this.dtDate.Value = new System.DateTime(2014, 10, 8, 16, 0, 33, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ausführungsdatum:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(105, 12);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(589, 20);
            this.txtSource.TabIndex = 14;
            // 
            // btnSearchSource
            // 
            this.btnSearchSource.Location = new System.Drawing.Point(700, 10);
            this.btnSearchSource.Name = "btnSearchSource";
            this.btnSearchSource.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSource.TabIndex = 15;
            this.btnSearchSource.Text = "Suchen";
            this.btnSearchSource.UseVisualStyleBackColor = true;
            this.btnSearchSource.Click += new System.EventHandler(this.btnSearchSource_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quelldatei (CSV):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Zieldatei:";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(9, 45);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(255, 20);
            this.txtTarget.TabIndex = 18;
            // 
            // btnSearchTarget
            // 
            this.btnSearchTarget.Location = new System.Drawing.Point(270, 45);
            this.btnSearchTarget.Name = "btnSearchTarget";
            this.btnSearchTarget.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTarget.TabIndex = 19;
            this.btnSearchTarget.Text = "Suchen";
            this.btnSearchTarget.UseVisualStyleBackColor = true;
            this.btnSearchTarget.Click += new System.EventHandler(this.btnZiel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(270, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Generieren";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(6, 84);
            this.pBar.MarqueeAnimationSpeed = 0;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(339, 23);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pBar.TabIndex = 21;
            this.pBar.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = "Entwickelt von Christopher Schenk \r\nDer Autor übernimmt keinerlei Haftung für eve" +
    "ntuelle Schäden!";
            // 
            // debtorBox
            // 
            this.debtorBox.Controls.Add(this.cbDtOfSgntr);
            this.debtorBox.Controls.Add(this.label14);
            this.debtorBox.Controls.Add(this.btnPasteReference);
            this.debtorBox.Controls.Add(this.cbAddToReferenceText);
            this.debtorBox.Controls.Add(this.label13);
            this.debtorBox.Controls.Add(this.txtReference);
            this.debtorBox.Controls.Add(this.btnPasteUsage);
            this.debtorBox.Controls.Add(this.cbAddToUsageText);
            this.debtorBox.Controls.Add(this.label12);
            this.debtorBox.Controls.Add(this.txtUsage);
            this.debtorBox.Controls.Add(this.numAmount);
            this.debtorBox.Controls.Add(this.cbAmount);
            this.debtorBox.Controls.Add(this.rbFixedAmount);
            this.debtorBox.Controls.Add(this.rbVariableAmount);
            this.debtorBox.Controls.Add(this.cbDebtBIC);
            this.debtorBox.Controls.Add(this.cbDebtIBAN);
            this.debtorBox.Controls.Add(this.label11);
            this.debtorBox.Controls.Add(this.label2);
            this.debtorBox.Controls.Add(this.cbDebtName1);
            this.debtorBox.Controls.Add(this.label1);
            this.debtorBox.Enabled = false;
            this.debtorBox.Location = new System.Drawing.Point(15, 76);
            this.debtorBox.Name = "debtorBox";
            this.debtorBox.Size = new System.Drawing.Size(409, 394);
            this.debtorBox.TabIndex = 23;
            this.debtorBox.TabStop = false;
            this.debtorBox.Text = "Debitor";
            // 
            // btnPasteReference
            // 
            this.btnPasteReference.Location = new System.Drawing.Point(326, 264);
            this.btnPasteReference.Name = "btnPasteReference";
            this.btnPasteReference.Size = new System.Drawing.Size(75, 23);
            this.btnPasteReference.TabIndex = 41;
            this.btnPasteReference.Text = "Einfügen";
            this.btnPasteReference.UseVisualStyleBackColor = true;
            this.btnPasteReference.Click += new System.EventHandler(this.btnPasteReference_Click);
            // 
            // cbAddToReferenceText
            // 
            this.cbAddToReferenceText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddToReferenceText.FormattingEnabled = true;
            this.cbAddToReferenceText.Location = new System.Drawing.Point(149, 266);
            this.cbAddToReferenceText.Name = "cbAddToReferenceText";
            this.cbAddToReferenceText.Size = new System.Drawing.Size(171, 21);
            this.cbAddToReferenceText.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Mandatsreferenz:";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(149, 198);
            this.txtReference.Multiline = true;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(252, 62);
            this.txtReference.TabIndex = 38;
            // 
            // btnPasteUsage
            // 
            this.btnPasteUsage.Location = new System.Drawing.Point(328, 361);
            this.btnPasteUsage.Name = "btnPasteUsage";
            this.btnPasteUsage.Size = new System.Drawing.Size(75, 23);
            this.btnPasteUsage.TabIndex = 37;
            this.btnPasteUsage.Text = "Einfügen";
            this.btnPasteUsage.UseVisualStyleBackColor = true;
            this.btnPasteUsage.Click += new System.EventHandler(this.btnPasteUsage_Click);
            // 
            // cbAddToUsageText
            // 
            this.cbAddToUsageText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddToUsageText.FormattingEnabled = true;
            this.cbAddToUsageText.Location = new System.Drawing.Point(151, 361);
            this.cbAddToUsageText.Name = "cbAddToUsageText";
            this.cbAddToUsageText.Size = new System.Drawing.Size(171, 21);
            this.cbAddToUsageText.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Verwendungszweck:";
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(151, 293);
            this.txtUsage.Multiline = true;
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(252, 62);
            this.txtUsage.TabIndex = 34;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAmount.Location = new System.Drawing.Point(149, 145);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(123, 20);
            this.numAmount.TabIndex = 31;
            // 
            // cbAmount
            // 
            this.cbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmount.FormattingEnabled = true;
            this.cbAmount.Location = new System.Drawing.Point(149, 171);
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(123, 21);
            this.cbAmount.TabIndex = 33;
            // 
            // rbFixedAmount
            // 
            this.rbFixedAmount.AutoSize = true;
            this.rbFixedAmount.Checked = true;
            this.rbFixedAmount.Location = new System.Drawing.Point(9, 145);
            this.rbFixedAmount.Name = "rbFixedAmount";
            this.rbFixedAmount.Size = new System.Drawing.Size(91, 17);
            this.rbFixedAmount.TabIndex = 31;
            this.rbFixedAmount.TabStop = true;
            this.rbFixedAmount.Text = "Fester Betrag:";
            this.rbFixedAmount.UseVisualStyleBackColor = true;
            // 
            // rbVariableAmount
            // 
            this.rbVariableAmount.AutoSize = true;
            this.rbVariableAmount.Location = new System.Drawing.Point(9, 172);
            this.rbVariableAmount.Name = "rbVariableAmount";
            this.rbVariableAmount.Size = new System.Drawing.Size(103, 17);
            this.rbVariableAmount.TabIndex = 32;
            this.rbVariableAmount.TabStop = true;
            this.rbVariableAmount.Text = "Betrag aus CSV:";
            this.rbVariableAmount.UseVisualStyleBackColor = true;
            // 
            // cbDebtBIC
            // 
            this.cbDebtBIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDebtBIC.FormattingEnabled = true;
            this.cbDebtBIC.Location = new System.Drawing.Point(149, 81);
            this.cbDebtBIC.Name = "cbDebtBIC";
            this.cbDebtBIC.Size = new System.Drawing.Size(123, 21);
            this.cbDebtBIC.TabIndex = 32;
            // 
            // cbDebtIBAN
            // 
            this.cbDebtIBAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDebtIBAN.FormattingEnabled = true;
            this.cbDebtIBAN.Location = new System.Drawing.Point(149, 54);
            this.cbDebtIBAN.Name = "cbDebtIBAN";
            this.cbDebtIBAN.Size = new System.Drawing.Size(123, 21);
            this.cbDebtIBAN.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Debitor BIC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Debitor IBAN:";
            // 
            // cbDebtName1
            // 
            this.cbDebtName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDebtName1.FormattingEnabled = true;
            this.cbDebtName1.Location = new System.Drawing.Point(149, 27);
            this.cbDebtName1.Name = "cbDebtName1";
            this.cbDebtName1.Size = new System.Drawing.Size(123, 21);
            this.cbDebtName1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Debitor Name:";
            // 
            // txtCreditorID
            // 
            this.txtCreditorID.Location = new System.Drawing.Point(149, 25);
            this.txtCreditorID.Name = "txtCreditorID";
            this.txtCreditorID.Size = new System.Drawing.Size(100, 20);
            this.txtCreditorID.TabIndex = 4;
            // 
            // columnHeaders
            // 
            this.columnHeaders.AutoSize = true;
            this.columnHeaders.Location = new System.Drawing.Point(519, 45);
            this.columnHeaders.Name = "columnHeaders";
            this.columnHeaders.Size = new System.Drawing.Size(175, 17);
            this.columnHeaders.TabIndex = 24;
            this.columnHeaders.Text = "Spalten enthalten Überschriften";
            this.columnHeaders.UseVisualStyleBackColor = true;
            // 
            // cbDebtName2
            // 
            this.cbDebtName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDebtName2.FormattingEnabled = true;
            this.cbDebtName2.Location = new System.Drawing.Point(293, 103);
            this.cbDebtName2.Name = "cbDebtName2";
            this.cbDebtName2.Size = new System.Drawing.Size(123, 21);
            this.cbDebtName2.TabIndex = 30;
            // 
            // creditorBox
            // 
            this.creditorBox.Controls.Add(this.label3);
            this.creditorBox.Controls.Add(this.label6);
            this.creditorBox.Controls.Add(this.label5);
            this.creditorBox.Controls.Add(this.txtCreditorID);
            this.creditorBox.Controls.Add(this.txtCreditorBic);
            this.creditorBox.Controls.Add(this.txtCreditorIBAN);
            this.creditorBox.Controls.Add(this.txtCreditorName);
            this.creditorBox.Controls.Add(this.label4);
            this.creditorBox.Enabled = false;
            this.creditorBox.Location = new System.Drawing.Point(430, 78);
            this.creditorBox.Name = "creditorBox";
            this.creditorBox.Size = new System.Drawing.Size(362, 137);
            this.creditorBox.TabIndex = 31;
            this.creditorBox.TabStop = false;
            this.creditorBox.Text = "Gläubiger";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(700, 41);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Laden";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // targetBox
            // 
            this.targetBox.Controls.Add(this.label7);
            this.targetBox.Controls.Add(this.dtDate);
            this.targetBox.Controls.Add(this.txtTarget);
            this.targetBox.Controls.Add(this.btnSearchTarget);
            this.targetBox.Controls.Add(this.pBar);
            this.targetBox.Controls.Add(this.label9);
            this.targetBox.Controls.Add(this.btnStart);
            this.targetBox.Controls.Add(this.label10);
            this.targetBox.Enabled = false;
            this.targetBox.Location = new System.Drawing.Point(430, 221);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(362, 249);
            this.targetBox.TabIndex = 33;
            this.targetBox.TabStop = false;
            this.targetBox.Text = "SEPA-Datei Erstellung";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 26);
            this.label14.TabIndex = 42;
            this.label14.Text = "Datum der Unterzeichnung\r\n des SEPA Mandates:";
            // 
            // cbDtOfSgntr
            // 
            this.cbDtOfSgntr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDtOfSgntr.FormattingEnabled = true;
            this.cbDtOfSgntr.Location = new System.Drawing.Point(149, 118);
            this.cbDtOfSgntr.Name = "cbDtOfSgntr";
            this.cbDtOfSgntr.Size = new System.Drawing.Size(123, 21);
            this.cbDtOfSgntr.TabIndex = 43;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 480);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.creditorBox);
            this.Controls.Add(this.cbDebtName2);
            this.Controls.Add(this.columnHeaders);
            this.Controls.Add(this.debtorBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnSearchSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "SEPA-XML Datei generieren";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.debtorBox.ResumeLayout(false);
            this.debtorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.creditorBox.ResumeLayout(false);
            this.creditorBox.PerformLayout();
            this.targetBox.ResumeLayout(false);
            this.targetBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreditorName;
        private System.Windows.Forms.TextBox txtCreditorIBAN;
        private System.Windows.Forms.TextBox txtCreditorBic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSearchSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnSearchTarget;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox debtorBox;
        private System.Windows.Forms.TextBox txtCreditorID;
        private System.Windows.Forms.CheckBox columnHeaders;
        private System.Windows.Forms.ComboBox cbDebtName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbDebtName2;
        private System.Windows.Forms.ComboBox cbDebtIBAN;
        private System.Windows.Forms.ComboBox cbDebtBIC;
        private System.Windows.Forms.Button btnPasteUsage;
        private System.Windows.Forms.ComboBox cbAddToUsageText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.ComboBox cbAmount;
        private System.Windows.Forms.RadioButton rbFixedAmount;
        private System.Windows.Forms.RadioButton rbVariableAmount;
        private System.Windows.Forms.GroupBox creditorBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPasteReference;
        private System.Windows.Forms.ComboBox cbAddToReferenceText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.GroupBox targetBox;
        private System.Windows.Forms.ComboBox cbDtOfSgntr;
        private System.Windows.Forms.Label label14;
    }
}

