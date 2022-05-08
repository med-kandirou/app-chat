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
using MySql.Data.MySqlClient;

namespace app_chat
{
    public partial class loginUser : UserControl
    {
        public loginUser()
        {
            InitializeComponent();
        }

        private void loginUser_Load(object sender, EventArgs e)
        {
            
        }

        private void toogle_CheckedChanged(object sender, EventArgs e)
        {
            if (toogle.Checked == true)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;

            }
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (User.checkchampslogin(email.Text, pass.Text))
            {
                MessageBox.Show("Oops ! You Forgot one Field Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!User.checkemail(email.Text))
            {
                MessageBox.Show("Email invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
                Database.Connecter();
                Database.cmd.CommandText = "SELECT * FROM `userinfo` WHERE Email='" + email.Text + "'";
                Database.cmd.Connection = Database.cnx;
                Database.da.SelectCommand = Database.cmd;
                Database.da.Fill(Database.dt);
                if (Database.dt.Rows[0][3].ToString().Equals(pass.Text))
                {
                    User.id = int.Parse(Database.dt.Rows[0][0].ToString());
                    User.nom = Database.dt.Rows[0][1].ToString();
                    User.email = Database.dt.Rows[0][2].ToString();
                    User.password = Database.dt.Rows[0][3].ToString();
                    User.image = ((byte[])Database.dt.Rows[0][4]);

                    User.close = true;
                    Formchat f2 = new Formchat();
                    f2.Show();

                    Database.dt.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Password or Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Database.deconnecter();
            
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

    }
}
