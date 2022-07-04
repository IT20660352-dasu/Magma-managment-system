namespace MagmaBuildLanka
{
    partial class ServiceDetailsForm
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
            this.textBoxServiceType = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxServiceType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxFullPayment = new System.Windows.Forms.TextBox();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.labelFinishdate = new System.Windows.Forms.Label();
            this.labelStratDate = new System.Windows.Forms.Label();
            this.labelFullPayment = new System.Windows.Forms.Label();
            this.labelServiceType = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxServiceType
            // 
            this.textBoxServiceType.Location = new System.Drawing.Point(451, 168);
            this.textBoxServiceType.Name = "textBoxServiceType";
            this.textBoxServiceType.Size = new System.Drawing.Size(195, 20);
            this.textBoxServiceType.TabIndex = 24;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(405, 332);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxServiceType.DisplayMember = "Select From List";
            this.comboBoxServiceType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.Items.AddRange(new object[] {
            "RENOVATION          ",
            "MAGMA CONSTRUCTION SERVICES ",
            "MAGMA STEEL WORK ",
            "ENGINEERING DESIGNING",
            "MAGMA LABOUR SUPPLY ",
            "MAGMA BROKERING-BUILDINGS  ",
            "MAGMA BROKERING -LANDS\")"});
            this.comboBoxServiceType.Location = new System.Drawing.Point(439, 141);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(177, 21);
            this.comboBoxServiceType.TabIndex = 22;
            // 
            // dateTimePickerFDate
            // 
            this.dateTimePickerFDate.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateTimePickerFDate.Location = new System.Drawing.Point(418, 277);
            this.dateTimePickerFDate.Name = "dateTimePickerFDate";
            this.dateTimePickerFDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePickerFDate.TabIndex = 21;
            // 
            // dateTimePickerSDate
            // 
            this.dateTimePickerSDate.Location = new System.Drawing.Point(439, 244);
            this.dateTimePickerSDate.Name = "dateTimePickerSDate";
            this.dateTimePickerSDate.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerSDate.TabIndex = 20;
            // 
            // textBoxFullPayment
            // 
            this.textBoxFullPayment.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFullPayment.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxFullPayment.Location = new System.Drawing.Point(452, 203);
            this.textBoxFullPayment.Name = "textBoxFullPayment";
            this.textBoxFullPayment.Size = new System.Drawing.Size(195, 20);
            this.textBoxFullPayment.TabIndex = 19;
            // 
            // textBoxPname
            // 
            this.textBoxPname.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPname.Location = new System.Drawing.Point(415, 105);
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(172, 20);
            this.textBoxPname.TabIndex = 18;
            // 
            // labelFinishdate
            // 
            this.labelFinishdate.AutoSize = true;
            this.labelFinishdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFinishdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFinishdate.Location = new System.Drawing.Point(341, 277);
            this.labelFinishdate.Name = "labelFinishdate";
            this.labelFinishdate.Size = new System.Drawing.Size(60, 13);
            this.labelFinishdate.TabIndex = 17;
            this.labelFinishdate.Text = "Finish Date";
            // 
            // labelStratDate
            // 
            this.labelStratDate.AutoSize = true;
            this.labelStratDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStratDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStratDate.Location = new System.Drawing.Point(364, 244);
            this.labelStratDate.Name = "labelStratDate";
            this.labelStratDate.Size = new System.Drawing.Size(52, 13);
            this.labelStratDate.TabIndex = 16;
            this.labelStratDate.Text = "StratDate";
            // 
            // labelFullPayment
            // 
            this.labelFullPayment.AutoSize = true;
            this.labelFullPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFullPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFullPayment.Location = new System.Drawing.Point(364, 208);
            this.labelFullPayment.Name = "labelFullPayment";
            this.labelFullPayment.Size = new System.Drawing.Size(67, 13);
            this.labelFullPayment.TabIndex = 15;
            this.labelFullPayment.Text = "Full Payment";
            // 
            // labelServiceType
            // 
            this.labelServiceType.AutoSize = true;
            this.labelServiceType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelServiceType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelServiceType.Location = new System.Drawing.Point(350, 160);
            this.labelServiceType.Name = "labelServiceType";
            this.labelServiceType.Size = new System.Drawing.Size(70, 13);
            this.labelServiceType.TabIndex = 14;
            this.labelServiceType.Text = "Service Type";
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProjectName.Location = new System.Drawing.Point(328, 108);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(71, 13);
            this.labelProjectName.TabIndex = 13;
            this.labelProjectName.Text = "Project Name";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClear.Location = new System.Drawing.Point(517, 332);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 23);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ServiceDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MagmaBuildLanka.Properties.Resources.new_pp1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxServiceType);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxServiceType);
            this.Controls.Add(this.dateTimePickerFDate);
            this.Controls.Add(this.dateTimePickerSDate);
            this.Controls.Add(this.textBoxFullPayment);
            this.Controls.Add(this.textBoxPname);
            this.Controls.Add(this.labelFinishdate);
            this.Controls.Add(this.labelStratDate);
            this.Controls.Add(this.labelFullPayment);
            this.Controls.Add(this.labelServiceType);
            this.Controls.Add(this.labelProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceDetailsForm";
            this.Text = "ServiceDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServiceType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxServiceType;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSDate;
        private System.Windows.Forms.TextBox textBoxFullPayment;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.Label labelFinishdate;
        private System.Windows.Forms.Label labelStratDate;
        private System.Windows.Forms.Label labelFullPayment;
        private System.Windows.Forms.Label labelServiceType;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Button buttonClear;
    }
}