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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStuName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(257, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "id：";
            // 
            // textBoxStuId
            // 
            this.textBoxStuId.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuId.Location = new System.Drawing.Point(399, 146);
            this.textBoxStuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStuId.Name = "textBoxStuId";
            this.textBoxStuId.Size = new System.Drawing.Size(213, 32);
            this.textBoxStuId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(257, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "psw：";
            // 
            // textBoxStuPsw
            // 
            this.textBoxStuPsw.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuPsw.Location = new System.Drawing.Point(399, 273);
            this.textBoxStuPsw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStuPsw.Name = "textBoxStuPsw";
            this.textBoxStuPsw.Size = new System.Drawing.Size(213, 32);
            this.textBoxStuPsw.TabIndex = 1;
            // 
            // buttonAddStu
            // 
            this.buttonAddStu.Location = new System.Drawing.Point(132, 383);
            this.buttonAddStu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddStu.Name = "buttonAddStu";
            this.buttonAddStu.Size = new System.Drawing.Size(172, 65);
            this.buttonAddStu.TabIndex = 2;
            this.buttonAddStu.Text = "添加学生";
            this.buttonAddStu.UseVisualStyleBackColor = true;
            this.buttonAddStu.Click += new System.EventHandler(this.buttonAddStu_Click);
            // 
            // buttonCancalAddStu
            // 
            this.buttonCancalAddStu.Location = new System.Drawing.Point(539, 383);
            this.buttonCancalAddStu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancalAddStu.Name = "buttonCancalAddStu";
            this.buttonCancalAddStu.Size = new System.Drawing.Size(172, 65);
            this.buttonCancalAddStu.TabIndex = 2;
            this.buttonCancalAddStu.Text = "取消";
            this.buttonCancalAddStu.UseVisualStyleBackColor = true;
            this.buttonCancalAddStu.Click += new System.EventHandler(this.buttonCancalAddStu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(257, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "name：";
            // 
            // textBoxStuName
            // 
            this.textBoxStuName.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStuName.Location = new System.Drawing.Point(399, 208);
            this.textBoxStuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStuName.Name = "textBoxStuName";
            this.textBoxStuName.Size = new System.Drawing.Size(213, 32);
            this.textBoxStuName.TabIndex = 1;
            // 
            // FormAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 541);
            this.Controls.Add(this.buttonCancalAddStu);
            this.Controls.Add(this.buttonAddStu);
            this.Controls.Add(this.textBoxStuName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStuPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStuId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStuName;
    }
}