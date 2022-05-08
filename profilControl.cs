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
    public partial class profilControl : UserControl
    {
        public profilControl()
        {
            InitializeComponent();
        }
        
        private void profilControl_Load(object sender, EventArgs e)
        {
            
            inputemail.Text = User.email;
            inputemail.Enabled = false;
            
            MemoryStream ms = new MemoryStream(User.image);
            Picchageinfo.Image = new Bitmap(ms);

        }
        Image imageuser;
        bool select=false;
        private void btnloadpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "image";
            ofd.Title = "Chose your picture";
            ofd.Filter = "image jpg(*.jpg) |*jpg|image png(*.png) |*png ";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                select = true;
                Picchageinfo.Image = Image.FromFile(ofd.FileName);
                imageuser = Image.FromFile(ofd.FileName);
            }
        }
        private void btnchangeinfo_Click(object sender, EventArgs e)
        {
            
            
                if (User.checkchampsignin(inputName.Text, inputPass.Text, inputconfirm.Text, inputemail.Text))
                {
                    MessageBox.Show("Oops!You Forgot one Field Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (inputPass.Text.ToString() != inputconfirm.Text.ToString())
                {
                    MessageBox.Show("Confirmation Password is False !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            try 
            { 
                if (select)
                {
                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte1 = (byte[])converter.ConvertTo(imageuser, typeof(byte[]));
                    Database.Connecter();
                    
                    Database.cmd.CommandText = "UPDATE `userinfo` set Nom=@nom, Password=@password, img=@img where email= '" + inputemail.Text + "'";
                    Database.cmd.Parameters.AddWithValue("nom", inputName.Text);
                    Database.cmd.Parameters.AddWithValue("password", inputPass.Text);
                    Database.cmd.Parameters.AddWithValue("img", imagebyte1);
                    Database.cmd.Connection = Database.cnx;
                    int row = Database.cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        User.nom = inputName.Text;
                        MessageBox.Show("Account Modified Successfully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ImageConverter converter1 = new ImageConverter();
                    byte[] imagebyte = (byte[])converter1.ConvertTo(imageuser, typeof(byte[]));
                    Database.Connecter();
                    Database.cmd.CommandText = "INSERT INTO `userinfo`(`img`) VALUES (@img) where email='" + inputemail.Text + "'";
                    Database.cmd.Parameters.AddWithValue("img", imagebyte);
                    Database.cmd.Connection = Database.cnx;

                    Database.cmd.ExecuteNonQuery();
                    Database.deconnecter();
                    btnchangeinfo.Enabled = false;
                }
                if (!select)
                {
                    Database.Connecter();
                    Database.cmd.CommandText = "UPDATE `userinfo` set Nom=@nom, Password=@password where email= '" + inputemail.Text + "'";
                    Database.cmd.Parameters.AddWithValue("nom", inputName.Text);
                    Database.cmd.Parameters.AddWithValue("password", inputPass.Text);
                    Database.cmd.Connection = Database.cnx;
                    int row = Database.cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Account Modified Successfully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Database.deconnecter();
                    btnchangeinfo.Enabled = false;
                }
            }
            catch (Exception) 
            { 
                MessageBox.Show("Return To Home"); 
            }

        }
    }
}
