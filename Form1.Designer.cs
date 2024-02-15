namespace exportTxt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            check_Show = new CheckBox();
            label1 = new Label();
            txt_Pwd = new TextBox();
            txt_Id = new TextBox();
            Label_Pwd = new Label();
            labelId = new Label();
            btn_Submit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Submit);
            groupBox1.Controls.Add(check_Show);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Pwd);
            groupBox1.Controls.Add(txt_Id);
            groupBox1.Controls.Add(Label_Pwd);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(130, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Input";
            // 
            // check_Show
            // 
            check_Show.AutoSize = true;
            check_Show.Location = new Point(322, 208);
            check_Show.Name = "check_Show";
            check_Show.Size = new Size(15, 14);
            check_Show.TabIndex = 5;
            check_Show.UseVisualStyleBackColor = true;
            check_Show.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 207);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "비밀번호 보이기";
            // 
            // txt_Pwd
            // 
            txt_Pwd.Location = new Point(173, 114);
            txt_Pwd.Name = "txt_Pwd";
            txt_Pwd.Size = new Size(177, 23);
            txt_Pwd.TabIndex = 3;
            txt_Pwd.UseSystemPasswordChar = true;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(176, 57);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(174, 23);
            txt_Id.TabIndex = 2;
            // 
            // Label_Pwd
            // 
            Label_Pwd.AutoSize = true;
            Label_Pwd.Location = new Point(36, 117);
            Label_Pwd.Name = "Label_Pwd";
            Label_Pwd.Size = new Size(57, 15);
            Label_Pwd.TabIndex = 1;
            Label_Pwd.Text = "Password";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(56, 60);
            labelId.Name = "labelId";
            labelId.Size = new Size(19, 15);
            labelId.TabIndex = 0;
            labelId.Text = "ID";
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(372, 234);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(75, 23);
            btn_Submit.TabIndex = 6;
            btn_Submit.Text = "제출";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox check_Show;
        private Label label1;
        private TextBox txt_Pwd;
        private TextBox txt_Id;
        private Label Label_Pwd;
        private Label labelId;
        private Button btn_Submit;
    }
}
