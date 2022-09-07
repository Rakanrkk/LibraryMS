namespace BookManageApp_Access.AdminForms.StuManageForms
{
    partial class FormAddStu
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
            this.textBoxStuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStuPsw = new System.Windows.Forms.TextBox();
            this.buttonAddStu = new System.Windows.Forms.Button();
            this.buttonCancalAddStu = new System.Windows.Forms.Button();
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
            // textBoxStuId
            // 
            this.textBoxStuId.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuId.Location = new System.Drawing.Point(449, 175);
            this.textBoxStuId.Name = "textBoxStuId";
            this.textBoxStuId.Size = new System.Drawing.Size(239, 37);
            this.textBoxStuId.TabIndex = 1;
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
            // textBoxStuPsw
            // 
            this.textBoxStuPsw.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuPsw.Location = new System.Drawing.Point(449, 240);
            this.textBoxStuPsw.Name = "textBoxStuPsw";
            this.textBoxStuPsw.Size = new System.Drawing.Size(239, 37);
            this.textBoxStuPsw.TabIndex = 1;
            // 
            // buttonAddStu
            // 
            this.buttonAddStu.Location = new System.Drawing.Point(148, 460);
            this.buttonAddStu.Name = "buttonAddStu";
            this.buttonAddStu.Size = new System.Drawing.Size(194, 78);
            this.buttonAddStu.TabIndex = 2;
            this.buttonAddStu.Text = "添加学生";
            this.buttonAddStu.UseVisualStyleBackColor = true;
            this.buttonAddStu.Click += new System.EventHandler(this.buttonAddStu_Click);
            // 
            // buttonCancalAddStu
            // 
            this.buttonCancalAddStu.Location = new System.Drawing.Point(606, 460);
            this.buttonCancalAddStu.Name = "buttonCancalAddStu";
            this.buttonCancalAddStu.Size = new System.Drawing.Size(194, 78);
            this.buttonCancalAddStu.TabIndex = 2;
            this.buttonCancalAddStu.Text = "取消";
            this.buttonCancalAddStu.UseVisualStyleBackColor = true;
            this.buttonCancalAddStu.Click += new System.EventHandler(this.buttonCancalAddStu_Click);
            // 
            // FormAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.Controls.Add(this.buttonCancalAddStu);
            this.Controls.Add(this.buttonAddStu);
            this.Controls.Add(this.textBoxStuPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStuId);
            this.Controls.Add(this.label1);
            this.Name = "FormAddStu";
            this.Text = "FormAddStu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStuId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStuPsw;
        private System.Windows.Forms.Button buttonAddStu;
        private System.Windows.Forms.Button buttonCancalAddStu;
    }
}