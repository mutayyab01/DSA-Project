using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top_Down_Car_Game form = new Top_Down_Car_Game();
            Login_page form1 = new Login_page();

            form1.Close();
            form1.Dispose();
            this.Hide();
            form.Show();





        }
    }
}
