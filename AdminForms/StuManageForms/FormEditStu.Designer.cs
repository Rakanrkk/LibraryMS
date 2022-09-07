namespace BookManageApp_Access.AdminForms.StuManageForms
{
    partial class FormEditStu
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
            this.buttonCancalAddStu = new System.Windows.Forms.Button();
            this.buttonAddStu = new System.Windows.Forms.Button();
            this.textBoxStuPsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStuId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStuName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancalAddStu
            // 
            this.buttonCancalAddStu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancalAddStu.Location = new System.Drawing.Point(626, 487);
            this.buttonCancalAddStu.Name = "buttonCancalAddStu";
            this.buttonCancalAddStu.Size = new System.Drawing.Size(194, 78);
            this.buttonCancalAddStu.TabIndex = 13;
            this.buttonCancalAddStu.Text = "取消";
            this.buttonCancalAddStu.UseVisualStyleBackColor = true;
            this.buttonCancalAddStu.Click += new System.EventHandler(this.buttonCancalAddStu_Click);
            // 
            // buttonAddStu
            // 
            this.buttonAddStu.Location = new System.Drawing.Point(168, 487);
            this.buttonAddStu.Name = "buttonAddStu";
            this.buttonAddStu.Size = new System.Drawing.Size(194, 78);
            this.buttonAddStu.TabIndex = 14;
            this.buttonAddStu.Text = "确认修改";
            this.buttonAddStu.UseVisualStyleBackColor = true;
            this.buttonAddStu.Click += new System.EventHandler(this.buttonEditStu_Click);
            // 
            // textBoxStuPsw
            // 
            this.textBoxStuPsw.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuPsw.Location = new System.Drawing.Point(466, 307);
            this.textBoxStuPsw.Name = "textBoxStuPsw";
            this.textBoxStuPsw.Size = new System.Drawing.Size(239, 37);
            this.textBoxStuPsw.TabIndex = 11;
            this.textBoxStuPsw.TextChanged += new System.EventHandler(this.textBoxStuPsw_TextChanged);
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
            // textBoxStuId
            // 
            this.textBoxStuId.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuId.Location = new System.Drawing.Point(466, 242);
            this.textBoxStuId.Name = "textBoxStuId";
            this.textBoxStuId.ReadOnly = true;
            this.textBoxStuId.Size = new System.Drawing.Size(239, 37);
            this.textBoxStuId.TabIndex = 12;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(306, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "name：";
            // 
            // textBoxStuName
            // 
            this.textBoxStuName.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuName.Location = new System.Drawing.Point(466, 370);
            this.textBoxStuName.Name = "textBoxStuName";
            this.textBoxStuName.Size = new System.Drawing.Size(239, 37);
            this.textBoxStuName.TabIndex = 11;
            this.textBoxStuName.TextChanged += new System.EventHandler(this.textBoxStuPsw_TextChanged);
            // 
            // FormEditStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 675);
            this.Controls.Add(this.buttonCancalAddStu);
            this.Controls.Add(this.buttonAddStu);
            this.Controls.Add(this.textBoxStuName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStuPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStuId);
            this.Controls.Add(this.label1);
            this.Name = "FormEditStu";
            this.Text = "编辑学生";
            this.Load += new System.EventHandler(this.FormEditStu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancalAddStu;
        private System.Windows.Forms.Button buttonAddStu;
        private System.Windows.Forms.TextBox textBoxStuPsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStuId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStuName;
    }
}