namespace MagmaBuildLanka
{
    partial class StaffDetailsForm
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxDEPARTMENT = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelGENDER = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxTPNO = new System.Windows.Forms.TextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTPNO = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(601, 173);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(62, 28);
            this.buttonUpdate.TabIndex = 33;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxDEPARTMENT
            // 
            this.textBoxDEPARTMENT.Location = new System.Drawing.Point(126, 159);
            this.textBoxDEPARTMENT.Name = "textBoxDEPARTMENT";
            this.textBoxDEPARTMENT.Size = new System.Drawing.Size(130, 20);
            this.textBoxDEPARTMENT.TabIndex = 32;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(151, 231);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(149, 20);
            this.textBoxDesignation.TabIndex = 31;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.Color.PowderBlue;
            this.radioButtonFemale.Location = new System.Drawing.Point(208, 92);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 30;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.BackColor = System.Drawing.Color.PowderBlue;
            this.RadioButtonMale.Location = new System.Drawing.Point(156, 93);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonMale.TabIndex = 29;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = false;
            // 
            // labelGENDER
            // 
            this.labelGENDER.AutoSize = true;
            this.labelGENDER.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelGENDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGENDER.Location = new System.Drawing.Point(153, 76);
            this.labelGENDER.Name = "labelGENDER";
            this.labelGENDER.Size = new System.Drawing.Size(65, 15);
            this.labelGENDER.TabIndex = 28;
            this.labelGENDER.Text = "GENDER";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(601, 207);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(62, 29);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxTPNO
            // 
            this.textBoxTPNO.Location = new System.Drawing.Point(258, 314);
            this.textBoxTPNO.Name = "textBoxTPNO";
            this.textBoxTPNO.Size = new System.Drawing.Size(132, 20);
            this.textBoxTPNO.TabIndex = 26;
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(447, 356);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(191, 20);
            this.textBoxEMAIL.TabIndex = 25;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(272, 39);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(174, 20);
            this.textBoxNAME.TabIndex = 24;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(444, 340);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 15);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "E Mail";
            // 
            // labelTPNO
            // 
            this.labelTPNO.AutoSize = true;
            this.labelTPNO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTPNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTPNO.Location = new System.Drawing.Point(236, 298);
            this.labelTPNO.Name = "labelTPNO";
            this.labelTPNO.Size = new System.Drawing.Size(48, 15);
            this.labelTPNO.TabIndex = 22;
            this.labelTPNO.Text = "TP NO";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignation.Location = new System.Drawing.Point(134, 215);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(99, 15);
            this.labelDesignation.TabIndex = 21;
            this.labelDesignation.Text = "DESIGNATION";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(113, 143);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(100, 15);
            this.labelDepartment.TabIndex = 20;
            this.labelDepartment.Text = "DEPARTMENT";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(269, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 15);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "NAME";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(601, 244);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(62, 32);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // StaffDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MagmaBuildLanka.Properties.Resources.Slide5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxDEPARTMENT);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.labelGENDER);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxTPNO);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTPNO);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDetailsForm";
            this.Text = "StaffDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxDEPARTMENT;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.Label labelGENDER;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxTPNO;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTPNO;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonDelete;
    }
}