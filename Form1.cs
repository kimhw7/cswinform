using System;
using System.Configuration;
using System.Diagnostics;

namespace exportTxt
{
    public partial class Form1 : Form
    {
        private MyConfig myConfig = new MyConfig();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pwd.UseSystemPasswordChar = !txt_Pwd.UseSystemPasswordChar;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // config���Ͽ� ������ ����
            if(txt_Id.Text != null && txt_Pwd.Text != null)
            {
                myConfig.SetData("UserId", txt_Id.Text);
                myConfig.SetData("UserPwd", txt_Pwd.Text);

                // �Է°� �ʱ�ȭ
                InitInput();


                // form2�� �Ѿ��
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
           
        }
        // initialize text
        private void InitInput()
        {
            txt_Id.Text = null;
            txt_Pwd.Text = null;
            check_Show.Checked = false;
        }
        // �Է¹��� ���� config ���� ����

    }
}
