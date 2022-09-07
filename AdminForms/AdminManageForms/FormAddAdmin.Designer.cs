namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    partial class FormAddAdmin
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
            this.textBoxAdminId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdminPsw = new System.Windows.Forms.TextBox();
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.buttonCancalAddAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(289, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "id：";
            // 
            // textBoxAdminId
            // 
            this.textBoxAdminId.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAdminId.Location = new System.Drawing.Point(449, 175);
            this.textBoxAdminId.Name = "textBoxAdminId";
            this.textBoxAdminId.Size = new System.Drawing.Size(239, 37);
            this.textBoxAdminId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(289, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "psw：";
            // 
            // textBoxAdminPsw
            // 
            this.textBoxAdminPsw.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAdminPsw.Location = new System.Drawing.Point(449, 240);
            this.textBoxAdminPsw.Name = "textBoxAdminPsw";
            this.textBoxAdminPsw.Size = new System.Drawing.Size(239, 37);
            this.textBoxAdminPsw.TabIndex = 1;
            // 
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.Location = new System.Drawing.Point(148, 460);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(194, 78);
            this.buttonAddAdmin.TabIndex = 2;
            this.buttonAddAdmin.Text = "添加管理";
            this.buttonAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonAddAdmin_Click);
            // 
            // buttonCancalAddAdmin
            // 
            this.buttonCancalAddAdmin.Location = new System.Drawing.Point(606, 460);
            this.buttonCancalAddAdmin.Name = "buttonCancalAddAdmin";
            this.buttonCancalAddAdmin.Size = new System.Drawing.Size(194, 78);
            this.buttonCancalAddAdmin.TabIndex = 2;
            this.buttonCancalAddAdmin.Text = "取消";
            this.buttonCancalAddAdmin.UseVisualStyleBackColor = true;
            this.buttonCancalAddAdmin.Click += new System.EventHandler(this.buttonCancalAddAdmin_Click);
            // 
            // FormAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.Controls.Add(this.buttonCancalAddAdmin);
            this.Controls.Add(this.buttonAddAdmin);
            this.Controls.Add(this.textBoxAdminPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdminId);
            this.Controls.Add(this.label1);
            this.Name = "FormAddAdmin";
            this.Text = "FormAddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdminId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdminPsw;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.Button buttonCancalAddAdmin;
    }
}