using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace app_chat
{
    public partial class Formchat : Form
    {
        public Formchat()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Formchat_Load(object sender, EventArgs e)
        {
            HomeControl h = new HomeControl();
            h.Dock = DockStyle.Fill;
            h.Location = new Point(189, 29);
            panelcontenu.Controls.Add(h);
            h.BringToFront();
            //getUserPic
            labelNom.Text = User.nom.ToString();
            MemoryStream ms = new MemoryStream(User.image);
            picuserHome.Image = new Bitmap(ms);
        }
        private void btnprofile_Click(object sender, EventArgs e)
        {
            profilControl p = new profilControl();
            
            p.Dock = DockStyle.Fill;
            p.Location = new Point(189, 29);
            panelcontenu.Controls.Add(p);
            p.BringToFront();

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            HomeControl h = new HomeControl();
            h.Dock = DockStyle.Fill;
            h.Location = new Point(189, 29);
            panelcontenu.Controls.Add(h);
            h.BringToFront();

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                User.close = false;
                this.Close();
                Form1 f2 = new Form1();
                f2.Show();
            }
            else
            {
                return;
            }

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
