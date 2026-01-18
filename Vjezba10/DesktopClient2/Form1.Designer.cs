namespace DesktopClient2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbUsers = new System.Windows.Forms.ComboBox();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose User";
            // 
            // CbUsers
            // 
            this.CbUsers.FormattingEnabled = true;
            this.CbUsers.Location = new System.Drawing.Point(179, 44);
            this.CbUsers.Name = "CbUsers";
            this.CbUsers.Size = new System.Drawing.Size(200, 24);
            this.CbUsers.TabIndex = 2;
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(179, 97);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(200, 22);
            this.TbId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(179, 147);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(200, 22);
            this.TbDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(38, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(179, 198);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(200, 22);
            this.DtpDate.TabIndex = 9;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(179, 261);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 32);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbItems
            // 
            this.LbItems.FormattingEnabled = true;
            this.LbItems.ItemHeight = 16;
            this.LbItems.Location = new System.Drawing.Point(450, 39);
            this.LbItems.Name = "LbItems";
            this.LbItems.Size = new System.Drawing.Size(324, 324);
            this.LbItems.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbItems);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.CbUsers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox LbItems;

        private System.Windows.Forms.Button BtnAdd;

        private System.Windows.Forms.DateTimePicker DtpDate;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox TbId;

        private System.Windows.Forms.ComboBox CbUsers;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}