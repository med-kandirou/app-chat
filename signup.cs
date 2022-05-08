using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace app_chat
{
    public partial class signup : UserControl
    {
        public signup()
        {
            InitializeComponent();
        }
        public Image imageuser;
        private void btnloadpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "image";
            ofd.Title = "Chose your picture";
            ofd.Filter = "image jpg(*.jpg) |*jpg|image png(*.png) |*png ";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureSign.Image = Image.FromFile(ofd.FileName);
                imageuser = Image.FromFile(ofd.FileName);
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (User.checkchampsignin(inputName.Text, inputPass.Text, inputconfirm.Text, inputemail.Text))
            {
                MessageBox.Show("Oops!You Forgot one Field Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!User.checkemail(inputemail.Text))
            {
                MessageBox.Show("Email invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (inputPass.Text.ToString() != inputconfirm.Text.ToString())
            {
                MessageBox.Show("Confirmation Password is False !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] imagebyte = (byte[])converter.ConvertTo(imageuser, typeof(byte[]));
                Database.Connecter();
                Database.cmd.CommandText = "INSERT INTO `userinfo`(`Nom`, `Email`, `Password`, `img`) VALUES (@nom,@email,@Password,@img)";
                Database.cmd.Parameters.AddWithValue("Nom", inputName.Text);
                Database.cmd.Parameters.AddWithValue("Email", inputemail.Text);
                Database.cmd.Parameters.AddWithValue("Password", inputPass.Text);
                Database.cmd.Parameters.AddWithValue("img", imagebyte);
                Database.cmd.Connection = Database.cnx;
                int row = Database.cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Account Created Successfully \nGo to login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inputemail.Text = string.Empty;
                    inputName.Text = string.Empty;
                    inputPass.Text = string.Empty;
                    inputconfirm.Text = string.Empty;
                }
                Database.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

    }
}
