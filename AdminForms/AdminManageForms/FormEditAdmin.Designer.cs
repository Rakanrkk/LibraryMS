namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    partial class FormEditAdmin
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
            this.buttonCancalAddAdmin = new System.Windows.Forms.Button();
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.textBoxAdminPsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdminId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancalAddAdmin
            // 
            this.buttonCancalAddAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancalAddAdmin.Location = new System.Drawing.Point(626, 487);
            this.buttonCancalAddAdmin.Name = "buttonCancalAddAdmin";
            this.buttonCancalAddAdmin.Size = new System.Drawing.Size(194, 78);
            this.buttonCancalAddAdmin.TabIndex = 13;
            this.buttonCancalAddAdmin.Text = "取消";
            this.buttonCancalAddAdmin.UseVisualStyleBackColor = true;
            this.buttonCancalAddAdmin.Click += new System.EventHandler(this.buttonCancalAddAdmin_Click);
            // 
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.Location = new System.Drawing.Point(168, 487);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(194, 78);
            this.buttonAddAdmin.TabIndex = 14;
            this.buttonAddAdmin.Text = "确认修改";
            this.buttonAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonEditAdmin_Click);
            // 
            // textBoxAdminPsw
            // 
            this.textBoxAdminPsw.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAdminPsw.Location = new System.Drawing.Point(466, 307);
            this.textBoxAdminPsw.Name = "textBoxAdminPsw";
            this.textBoxAdminPsw.Size = new System.Drawing.Size(239, 37);
            this.textBoxAdminPsw.TabIndex = 11;
            this.textBoxAdminPsw.TextChanged += new System.EventHandler(this.textBoxAdminPsw_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(306, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "psw：";
            // 
            // textBoxAdminId
            // 
            this.textBoxAdminId.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAdminId.Location = new System.Drawing.Point(466, 242);
            this.textBoxAdminId.Name = "textBoxAdminId";
            this.textBoxAdminId.ReadOnly = true;
            this.textBoxAdminId.Size = new System.Drawing.Size(239, 37);
            this.textBoxAdminId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(306, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "id：";
            // 
            // FormEditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 675);
            this.Controls.Add(this.buttonCancalAddAdmin);
            this.Controls.Add(this.buttonAddAdmin);
            this.Controls.Add(this.textBoxAdminPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdminId);
            this.Controls.Add(this.label1);
            this.Name = "FormEditAdmin";
            this.Text = "编辑管理员";
            this.Load += new System.EventHandler(this.FormEditAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancalAddAdmin;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.TextBox textBoxAdminPsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdminId;
        private System.Windows.Forms.Label label1;
    }
}