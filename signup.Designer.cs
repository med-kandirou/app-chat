
namespace app_chat
{
    partial class signup
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.PictureSign = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnloadpic = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputName = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btncreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.confirmpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputconfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureSign
            // 
            this.PictureSign.Image = ((System.Drawing.Image)(resources.GetObject("PictureSign.Image")));
            this.PictureSign.Location = new System.Drawing.Point(155, 106);
            this.PictureSign.Name = "PictureSign";
            this.PictureSign.ShadowDecoration.BorderRadius = 50;
            this.PictureSign.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureSign.ShadowDecoration.Parent = this.PictureSign;
            this.PictureSign.Size = new System.Drawing.Size(95, 95);
            this.PictureSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSign.TabIndex = 0;
            this.PictureSign.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create your account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(28, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your picture : ";
            // 
            // btnloadpic
            // 
            this.btnloadpic.BorderRadius = 17;
            this.btnloadpic.CheckedState.Parent = this.btnloadpic;
            this.btnloadpic.CustomImages.Parent = this.btnloadpic;
            this.btnloadpic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadpic.ForeColor = System.Drawing.Color.White;
            this.btnloadpic.HoverState.Parent = this.btnloadpic;
            this.btnloadpic.Location = new System.Drawing.Point(156, 212);
            this.btnloadpic.Name = "btnloadpic";
            this.btnloadpic.ShadowDecoration.Parent = this.btnloadpic;
            this.btnloadpic.Size = new System.Drawing.Size(94, 35);
            this.btnloadpic.TabIndex = 3;
            this.btnloadpic.Text = "Load";
            this.btnloadpic.Click += new System.EventHandler(this.btnloadpic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(352, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(352, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(28, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(28, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Confirm  pass :";
            // 
            // inputemail
            // 
            this.inputemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.inputemail.BorderRadius = 15;
            this.inputemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputemail.DefaultText = "";
            this.inputemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputemail.DisabledState.Parent = this.inputemail;
            this.inputemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputemail.FocusedState.Parent = this.inputemail;
            this.inputemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputemail.HoverState.Parent = this.inputemail;
            this.inputemail.IconLeft = ((System.Drawing.Image)(resources.GetObject("inputemail.IconLeft")));
            this.inputemail.Location = new System.Drawing.Point(448, 115);
            this.inputemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputemail.Name = "inputemail";
            this.inputemail.PasswordChar = '\0';
            this.inputemail.PlaceholderText = "Example@gmail.com";
            this.inputemail.SelectedText = "";
            this.inputemail.ShadowDecoration.Parent = this.inputemail;
            this.inputemail.Size = new System.Drawing.Size(220, 36);
            this.inputemail.TabIndex = 8;
            // 
            // inputName
            // 
            this.inputName.BackColor = System.Drawing.Color.Transparent;
            this.inputName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.inputName.BorderRadius = 15;
            this.inputName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputName.DefaultText = "";
            this.inputName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputName.DisabledState.Parent = this.inputName;
            this.inputName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputName.FocusedState.Parent = this.inputName;
            this.inputName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.inputName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputName.HoverState.Parent = this.inputName;
            this.inputName.IconLeft = ((System.Drawing.Image)(resources.GetObject("inputName.IconLeft")));
            this.inputName.Location = new System.Drawing.Point(448, 183);
            this.inputName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputName.Name = "inputName";
            this.inputName.PasswordChar = '\0';
            this.inputName.PlaceholderText = "Ex: Mohamed";
            this.inputName.SelectedText = "";
            this.inputName.ShadowDecoration.Parent = this.inputName;
            this.inputName.Size = new System.Drawing.Size(173, 36);
            this.inputName.TabIndex = 9;
            // 
            // inputPass
            // 
            this.inputPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.inputPass.BorderRadius = 15;
            this.inputPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPass.DefaultText = "";
            this.inputPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPass.DisabledState.Parent = this.inputPass;
            this.inputPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPass.FocusedState.Parent = this.inputPass;
            this.inputPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.inputPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPass.HoverState.Parent = this.inputPass;
            this.inputPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("inputPass.IconLeft")));
            this.inputPass.Location = new System.Drawing.Point(155, 287);
            this.inputPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputPass.Name = "inputPass";
            this.inputPass.PasswordChar = '\0';
            this.inputPass.PlaceholderText = "Ex :Tdi201";
            this.inputPass.SelectedText = "";
            this.inputPass.ShadowDecoration.Parent = this.inputPass;
            this.inputPass.Size = new System.Drawing.Size(178, 36);
            this.inputPass.TabIndex = 10;
            this.inputPass.UseSystemPasswordChar = true;
            // 
            // btncreate
            // 
            this.btncreate.BorderRadius = 12;
            this.btncreate.CheckedState.Parent = this.btncreate;
            this.btncreate.CustomImages.Parent = this.btncreate;
            this.btncreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btncreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btncreate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.ForeColor = System.Drawing.Color.White;
            this.btncreate.HoverState.Parent = this.btncreate;
            this.btncreate.Location = new System.Drawing.Point(474, 308);
            this.btncreate.Name = "btncreate";
            this.btncreate.ShadowDecoration.Parent = this.btncreate;
            this.btncreate.Size = new System.Drawing.Size(120, 45);
            this.btncreate.TabIndex = 12;
            this.btncreate.Text = "Sign Up";
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // confirmpass
            // 
            this.confirmpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.confirmpass.BorderRadius = 15;
            this.confirmpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmpass.DefaultText = "";
            this.confirmpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmpass.DisabledState.Parent = this.confirmpass;
            this.confirmpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmpass.FocusedState.Parent = this.confirmpass;
            this.confirmpass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.confirmpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmpass.HoverState.Parent = this.confirmpass;
            this.confirmpass.Location = new System.Drawing.Point(207, 458);
            this.confirmpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.PasswordChar = '\0';
            this.confirmpass.PlaceholderText = "";
            this.confirmpass.SelectedText = "";
            this.confirmpass.ShadowDecoration.Parent = this.confirmpass;
            this.confirmpass.Size = new System.Drawing.Size(237, 47);
            this.confirmpass.TabIndex = 13;
            // 
            // inputconfirm
            // 
            this.inputconfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.inputconfirm.BorderRadius = 15;
            this.inputconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputconfirm.DefaultText = "";
            this.inputconfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputconfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputconfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputconfirm.DisabledState.Parent = this.inputconfirm;
            this.inputconfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputconfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputconfirm.FocusedState.Parent = this.inputconfirm;
            this.inputconfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.inputconfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputconfirm.HoverState.Parent = this.inputconfirm;
            this.inputconfirm.IconLeft = ((System.Drawing.Image)(resources.GetObject("inputconfirm.IconLeft")));
            this.inputconfirm.Location = new System.Drawing.Point(153, 357);
            this.inputconfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputconfirm.Name = "inputconfirm";
            this.inputconfirm.PasswordChar = '*';
            this.inputconfirm.PlaceholderText = "Repeat Password";
            this.inputconfirm.SelectedText = "";
            this.inputconfirm.ShadowDecoration.Parent = this.inputconfirm;
            this.inputconfirm.Size = new System.Drawing.Size(178, 36);
            this.inputconfirm.TabIndex = 14;
            this.inputconfirm.UseSystemPasswordChar = true;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(110, 81);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.logo);
            this.Controls.Add(this.inputconfirm);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnloadpic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureSign);
            this.Name = "signup";
            this.Size = new System.Drawing.Size(811, 430);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnloadpic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox inputemail;
        private Guna.UI2.WinForms.Guna2TextBox inputName;
        private Guna.UI2.WinForms.Guna2TextBox inputPass;
        private Guna.UI2.WinForms.Guna2GradientButton btncreate;
        private Guna.UI2.WinForms.Guna2TextBox confirmpass;
        private Guna.UI2.WinForms.Guna2TextBox inputconfirm;
        private System.Windows.Forms.PictureBox logo;
    }
}
