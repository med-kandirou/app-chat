using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }
        
        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit ?","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr==DialogResult.OK)
            {
                Application.Exit();
            }
            else {
                return;  
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            loginUser login = new loginUser();
            login.Dock = DockStyle.Fill;
            login.Location = new Point(0, 24);
            loginpanel.Controls.Add(login);
            login.BringToFront();
        }

        private void gunasignup_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            s.Dock = DockStyle.Fill;
            s.Location= new Point(0, 72);
            loginpanel.Controls.Add(s);
            s.BringToFront();

           
        }

        private void gunalogin_Click(object sender, EventArgs e)
        {
            loginUser l = new loginUser();
            l.Dock = DockStyle.Fill;
            l.Location = new Point(0, 72);
            loginpanel.Controls.Add(l);
            l.BringToFront();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {

            if (User.close == true)
            {
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
