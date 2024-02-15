using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exportTxt
{
    public partial class Form2 : Form
    {
        private MyConfig myConfig = new MyConfig();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                txt_UserId.Text = myConfig.getData("UserId");
                txt_UserPwd.Text = myConfig.getData("UserPwd");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
    }
}
