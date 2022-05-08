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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }
        
        private void timerGetSms_Tick(object sender, EventArgs e)
        {
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.AllowUserToAddRows = false;
            
            dataGridView1.Rows.Clear();
  
            Database.Connecter();    
            Database.cmd = new MySqlCommand("SELECT userinfo.Nom, message.message FROM userinfo INNER JOIN message ON userinfo.Uid = message.UidF;", Database.cnx);
            Database.rd = Database.cmd.ExecuteReader();
            while (Database.rd.Read())
            {
                
                dataGridView1.Rows.Add(" "+Database.rd[0].ToString()+ " : " + Database.rd[1].ToString()+ "\n");
               
            }
            Database.deconnecter();
        }
        private void HomeControl_Load(object sender, EventArgs e)
        {
            timerGetSms.Start();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Connecter();
                Database.cmd.CommandText = "INSERT INTO `message`(`message`, `UidF`) VALUES ('"+ messagetext.Text + "'," + User.id + ")";
                Database.cmd.Connection = Database.cnx;
                Database.cmd.ExecuteNonQuery();
                Database.deconnecter();
                messagetext.Text = string.Empty;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
