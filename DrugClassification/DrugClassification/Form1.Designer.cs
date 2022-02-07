namespace DrugClassification
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelAge = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelSex = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelBP = new System.Windows.Forms.Label();
            this.labelCholesterol = new System.Windows.Forms.Label();
            this.comboBoxBP = new System.Windows.Forms.ComboBox();
            this.comboBoxCholesterol = new System.Windows.Forms.ComboBox();
            this.labelNatoK = new System.Windows.Forms.Label();
            this.textBoxNatoK = new System.Windows.Forms.TextBox();
            this.labelDrug = new System.Windows.Forms.Label();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxInsertData = new System.Windows.Forms.GroupBox();
            this.groupBoxAnalysisResults = new System.Windows.Forms.GroupBox();
            this.labelDrugType = new System.Windows.Forms.Label();
            this.groupBoxClearData = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.groupBoxInsertData.SuspendLayout();
            this.groupBoxAnalysisResults.SuspendLayout();
            this.groupBoxClearData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAge.Location = new System.Drawing.Point(29, 36);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(43, 20);
            this.labelAge.TabIndex = 0;
            this.labelAge.Text = "Age:";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownAge.Location = new System.Drawing.Point(85, 33);
            this.numericUpDownAge.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(65, 24);
            this.numericUpDownAge.TabIndex = 1;
            this.numericUpDownAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSex.Location = new System.Drawing.Point(28, 118);
            this.labelSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(42, 20);
            this.labelSex.TabIndex = 2;
            this.labelSex.Text = "Sex:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMale.Location = new System.Drawing.Point(108, 118);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(66, 24);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonFemale.Location = new System.Drawing.Point(223, 118);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(85, 24);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelBP
            // 
            this.labelBP.AutoSize = true;
            this.labelBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBP.Location = new System.Drawing.Point(29, 199);
            this.labelBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBP.Name = "labelBP";
            this.labelBP.Size = new System.Drawing.Size(175, 20);
            this.labelBP.TabIndex = 5;
            this.labelBP.Text = "Blood Pressure Level:";
            // 
            // labelCholesterol
            // 
            this.labelCholesterol.AutoSize = true;
            this.labelCholesterol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCholesterol.Location = new System.Drawing.Point(29, 295);
            this.labelCholesterol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCholesterol.Name = "labelCholesterol";
            this.labelCholesterol.Size = new System.Drawing.Size(144, 20);
            this.labelCholesterol.TabIndex = 7;
            this.labelCholesterol.Text = "Cholesterol Level:";
            // 
            // comboBoxBP
            // 
            this.comboBoxBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBP.FormattingEnabled = true;
            this.comboBoxBP.Items.AddRange(new object[] {
            "LOW",
            "NORMAL",
            "HIGH"});
            this.comboBoxBP.Location = new System.Drawing.Point(224, 199);
            this.comboBoxBP.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBP.Name = "comboBoxBP";
            this.comboBoxBP.Size = new System.Drawing.Size(160, 24);
            this.comboBoxBP.TabIndex = 8;
            // 
            // comboBoxCholesterol
            // 
            this.comboBoxCholesterol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCholesterol.FormattingEnabled = true;
            this.comboBoxCholesterol.Items.AddRange(new object[] {
            "NORMAL",
            "HIGH"});
            this.comboBoxCholesterol.Location = new System.Drawing.Point(223, 295);
            this.comboBoxCholesterol.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCholesterol.Name = "comboBoxCholesterol";
            this.comboBoxCholesterol.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCholesterol.TabIndex = 9;
            // 
            // labelNatoK
            // 
            this.labelNatoK.AutoSize = true;
            this.labelNatoK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNatoK.Location = new System.Drawing.Point(29, 384);
            this.labelNatoK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNatoK.Name = "labelNatoK";
            this.labelNatoK.Size = new System.Drawing.Size(217, 20);
            this.labelNatoK.TabIndex = 10;
            this.labelNatoK.Text = "Sodium to Potassium Ratio:";
            // 
            // textBoxNatoK
            // 
            this.textBoxNatoK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNatoK.Location = new System.Drawing.Point(267, 379);
            this.textBoxNatoK.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNatoK.Name = "textBoxNatoK";
            this.textBoxNatoK.Size = new System.Drawing.Size(116, 26);
            this.textBoxNatoK.TabIndex = 11;
            // 
            // labelDrug
            // 
            this.labelDrug.AutoSize = true;
            this.labelDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDrug.Location = new System.Drawing.Point(29, 123);
            this.labelDrug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrug.Name = "labelDrug";
            this.labelDrug.Size = new System.Drawing.Size(92, 20);
            this.labelDrug.TabIndex = 12;
            this.labelDrug.Text = "Drug Type:";
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnalyze.Location = new System.Drawing.Point(33, 50);
            this.buttonAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(267, 49);
            this.buttonAnalyze.TabIndex = 13;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(33, 44);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(267, 49);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxInsertData
            // 
            this.groupBoxInsertData.Controls.Add(this.labelBP);
            this.groupBoxInsertData.Controls.Add(this.labelAge);
            this.groupBoxInsertData.Controls.Add(this.numericUpDownAge);
            this.groupBoxInsertData.Controls.Add(this.labelSex);
            this.groupBoxInsertData.Controls.Add(this.textBoxNatoK);
            this.groupBoxInsertData.Controls.Add(this.radioButtonMale);
            this.groupBoxInsertData.Controls.Add(this.labelNatoK);
            this.groupBoxInsertData.Controls.Add(this.radioButtonFemale);
            this.groupBoxInsertData.Controls.Add(this.comboBoxCholesterol);
            this.groupBoxInsertData.Controls.Add(this.labelCholesterol);
            this.groupBoxInsertData.Controls.Add(this.comboBoxBP);
            this.groupBoxInsertData.Location = new System.Drawing.Point(16, 15);
            this.groupBoxInsertData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInsertData.Name = "groupBoxInsertData";
            this.groupBoxInsertData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInsertData.Size = new System.Drawing.Size(433, 421);
            this.groupBoxInsertData.TabIndex = 15;
            this.groupBoxInsertData.TabStop = false;
            this.groupBoxInsertData.Text = "Insert Data";
            // 
            // groupBoxAnalysisResults
            // 
            this.groupBoxAnalysisResults.Controls.Add(this.labelDrugType);
            this.groupBoxAnalysisResults.Controls.Add(this.buttonAnalyze);
            this.groupBoxAnalysisResults.Controls.Add(this.labelDrug);
            this.groupBoxAnalysisResults.Location = new System.Drawing.Point(457, 15);
            this.groupBoxAnalysisResults.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAnalysisResults.Name = "groupBoxAnalysisResults";
            this.groupBoxAnalysisResults.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAnalysisResults.Size = new System.Drawing.Size(327, 288);
            this.groupBoxAnalysisResults.TabIndex = 16;
            this.groupBoxAnalysisResults.TabStop = false;
            this.groupBoxAnalysisResults.Text = "Analysis Results";
            // 
            // labelDrugType
            // 
            this.labelDrugType.AutoSize = true;
            this.labelDrugType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDrugType.Location = new System.Drawing.Point(89, 173);
            this.labelDrugType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrugType.MinimumSize = new System.Drawing.Size(150, 50);
            this.labelDrugType.Name = "labelDrugType";
            this.labelDrugType.Size = new System.Drawing.Size(150, 50);
            this.labelDrugType.TabIndex = 14;
            this.labelDrugType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxClearData
            // 
            this.groupBoxClearData.Controls.Add(this.buttonClear);
            this.groupBoxClearData.Location = new System.Drawing.Point(457, 313);
            this.groupBoxClearData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxClearData.Name = "groupBoxClearData";
            this.groupBoxClearData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxClearData.Size = new System.Drawing.Size(327, 123);
            this.groupBoxClearData.TabIndex = 17;
            this.groupBoxClearData.TabStop = false;
            this.groupBoxClearData.Text = "Clear Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxClearData);
            this.Controls.Add(this.groupBoxAnalysisResults);
            this.Controls.Add(this.groupBoxInsertData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Drug Classifier";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.groupBoxInsertData.ResumeLayout(false);
            this.groupBoxInsertData.PerformLayout();
            this.groupBoxAnalysisResults.ResumeLayout(false);
            this.groupBoxAnalysisResults.PerformLayout();
            this.groupBoxClearData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelBP;
        private System.Windows.Forms.Label labelCholesterol;
        private System.Windows.Forms.ComboBox comboBoxBP;
        private System.Windows.Forms.ComboBox comboBoxCholesterol;
        private System.Windows.Forms.Label labelNatoK;
        private System.Windows.Forms.TextBox textBoxNatoK;
        private System.Windows.Forms.Label labelDrug;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxInsertData;
        private System.Windows.Forms.GroupBox groupBoxAnalysisResults;
        private System.Windows.Forms.Label labelDrugType;
        private System.Windows.Forms.GroupBox groupBoxClearData;
    }
}

