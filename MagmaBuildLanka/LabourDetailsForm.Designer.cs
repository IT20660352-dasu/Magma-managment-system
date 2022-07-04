namespace MagmaBuildLanka
{
    partial class LabourDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClearButton = new System.Windows.Forms.Button();
            this.buttonLOAD = new System.Windows.Forms.Button();
            this.dataGridViewlabour = new System.Windows.Forms.DataGridView();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.labelNIC = new System.Windows.Forms.Label();
            this.textBoxNICNo = new System.Windows.Forms.TextBox();
            this.textBoxTPNO = new System.Windows.Forms.TextBox();
            this.textBoxADDRESS = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.labelTPNO = new System.Windows.Forms.Label();
            this.labelADDRESS = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlabour)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(63, 354);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(55, 23);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // buttonLOAD
            // 
            this.buttonLOAD.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonLOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOAD.Location = new System.Drawing.Point(63, 327);
            this.buttonLOAD.Name = "buttonLOAD";
            this.buttonLOAD.Size = new System.Drawing.Size(55, 22);
            this.buttonLOAD.TabIndex = 24;
            this.buttonLOAD.Text = "LOAD";
            this.buttonLOAD.UseVisualStyleBackColor = false;
            this.buttonLOAD.Click += new System.EventHandler(this.buttonLOAD_Click);
            // 
            // dataGridViewlabour
            // 
            this.dataGridViewlabour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewlabour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewlabour.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewlabour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewlabour.Location = new System.Drawing.Point(202, 198);
            this.dataGridViewlabour.Name = "dataGridViewlabour";
            this.dataGridViewlabour.Size = new System.Drawing.Size(466, 215);
            this.dataGridViewlabour.TabIndex = 23;
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSAVE.Location = new System.Drawing.Point(63, 297);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(56, 24);
            this.buttonSAVE.TabIndex = 22;
            this.buttonSAVE.Text = "SAVE";
            this.buttonSAVE.UseVisualStyleBackColor = false;
            this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.BackColor = System.Drawing.Color.OrangeRed;
            this.labelNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIC.Location = new System.Drawing.Point(452, 152);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(50, 13);
            this.labelNIC.TabIndex = 21;
            this.labelNIC.Text = "NIC NO";
            // 
            // textBoxNICNo
            // 
            this.textBoxNICNo.Location = new System.Drawing.Point(519, 149);
            this.textBoxNICNo.Name = "textBoxNICNo";
            this.textBoxNICNo.Size = new System.Drawing.Size(149, 20);
            this.textBoxNICNo.TabIndex = 20;
            // 
            // textBoxTPNO
            // 
            this.textBoxTPNO.Location = new System.Drawing.Point(519, 101);
            this.textBoxTPNO.Name = "textBoxTPNO";
            this.textBoxTPNO.Size = new System.Drawing.Size(149, 20);
            this.textBoxTPNO.TabIndex = 19;
            // 
            // textBoxADDRESS
            // 
            this.textBoxADDRESS.Location = new System.Drawing.Point(259, 145);
            this.textBoxADDRESS.Name = "textBoxADDRESS";
            this.textBoxADDRESS.Size = new System.Drawing.Size(149, 20);
            this.textBoxADDRESS.TabIndex = 18;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(259, 105);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(149, 20);
            this.textBoxNAME.TabIndex = 17;
            // 
            // labelTPNO
            // 
            this.labelTPNO.AutoSize = true;
            this.labelTPNO.BackColor = System.Drawing.Color.OrangeRed;
            this.labelTPNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTPNO.Location = new System.Drawing.Point(458, 106);
            this.labelTPNO.Name = "labelTPNO";
            this.labelTPNO.Size = new System.Drawing.Size(44, 15);
            this.labelTPNO.TabIndex = 16;
            this.labelTPNO.Text = "TPNO";
            // 
            // labelADDRESS
            // 
            this.labelADDRESS.AutoSize = true;
            this.labelADDRESS.BackColor = System.Drawing.Color.OrangeRed;
            this.labelADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelADDRESS.Location = new System.Drawing.Point(173, 145);
            this.labelADDRESS.Name = "labelADDRESS";
            this.labelADDRESS.Size = new System.Drawing.Size(72, 15);
            this.labelADDRESS.TabIndex = 15;
            this.labelADDRESS.Text = "ADDRESS";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.OrangeRed;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(199, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 15);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "NAME";
            // 
            // LabourDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MagmaBuildLanka.Properties.Resources.Slide4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.buttonLOAD);
            this.Controls.Add(this.dataGridViewlabour);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.labelNIC);
            this.Controls.Add(this.textBoxNICNo);
            this.Controls.Add(this.textBoxTPNO);
            this.Controls.Add(this.textBoxADDRESS);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.labelTPNO);
            this.Controls.Add(this.labelADDRESS);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LabourDetailsForm";
            this.Text = "LabourDetailsForm";
            this.Load += new System.EventHandler(this.LabourDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlabour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button buttonLOAD;
        private System.Windows.Forms.DataGridView dataGridViewlabour;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.TextBox textBoxNICNo;
        private System.Windows.Forms.TextBox textBoxTPNO;
        private System.Windows.Forms.TextBox textBoxADDRESS;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label labelTPNO;
        private System.Windows.Forms.Label labelADDRESS;
        private System.Windows.Forms.Label labelName;
    }
}