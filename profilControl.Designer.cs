
namespace app_chat
{
    partial class profilControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilControl));
            this.inputconfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputName = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnloadpic = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Picchageinfo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnchangeinfo = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.Picchageinfo)).BeginInit();
            this.SuspendLayout();
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
            this.inputconfirm.Location = new System.Drawing.Point(257, 345);
            this.inputconfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputconfirm.Name = "inputconfirm";
            this.inputconfirm.PasswordChar = '*';
            this.inputconfirm.PlaceholderText = "Repeat Password";
            this.inputconfirm.SelectedText = "";
            this.inputconfirm.ShadowDecoration.Parent = this.inputconfirm;
            this.inputconfirm.Size = new System.Drawing.Size(178, 36);
            this.inputconfirm.TabIndex = 18;
            this.inputconfirm.UseSystemPasswordChar = true;
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
            this.inputPass.Location = new System.Drawing.Point(259, 288);
            this.inputPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputPass.Name = "inputPass";
            this.inputPass.PasswordChar = '\0';
            this.inputPass.PlaceholderText = "Ex :Tdi201";
            this.inputPass.SelectedText = "";
            this.inputPass.ShadowDecoration.Parent = this.inputPass;
            this.inputPass.Size = new System.Drawing.Size(178, 36);
            this.inputPass.TabIndex = 17;
            this.inputPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(132, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Confirm  pass :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(132, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password :";
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
            this.inputName.Location = new System.Drawing.Point(266, 230);
            this.inputName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputName.Name = "inputName";
            this.inputName.PasswordChar = '\0';
            this.inputName.PlaceholderText = "Ex: Mohamed";
            this.inputName.SelectedText = "";
            this.inputName.ShadowDecoration.Parent = this.inputName;
            this.inputName.Size = new System.Drawing.Size(173, 36);
            this.inputName.TabIndex = 22;
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
            this.inputemail.Location = new System.Drawing.Point(217, 165);
            this.inputemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputemail.Name = "inputemail";
            this.inputemail.PasswordChar = '\0';
            this.inputemail.PlaceholderText = "Example@gmail.com";
            this.inputemail.SelectedText = "";
            this.inputemail.ShadowDecoration.Parent = this.inputemail;
            this.inputemail.Size = new System.Drawing.Size(220, 36);
            this.inputemail.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(132, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(132, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email : ";
            // 
            // btnloadpic
            // 
            this.btnloadpic.BorderRadius = 17;
            this.btnloadpic.CheckedState.Parent = this.btnloadpic;
            this.btnloadpic.CustomImages.Parent = this.btnloadpic;
            this.btnloadpic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadpic.ForeColor = System.Drawing.Color.White;
            this.btnloadpic.HoverState.Parent = this.btnloadpic;
            this.btnloadpic.Location = new System.Drawing.Point(266, 115);
            this.btnloadpic.Name = "btnloadpic";
            this.btnloadpic.ShadowDecoration.Parent = this.btnloadpic;
            this.btnloadpic.Size = new System.Drawing.Size(94, 35);
            this.btnloadpic.TabIndex = 25;
            this.btnloadpic.Text = "Load";
            this.btnloadpic.Click += new System.EventHandler(this.btnloadpic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(132, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Your picture : ";
            // 
            // Picchageinfo
            // 
            this.Picchageinfo.Image = ((System.Drawing.Image)(resources.GetObject("Picchageinfo.Image")));
            this.Picchageinfo.Location = new System.Drawing.Point(266, 14);
            this.Picchageinfo.Name = "Picchageinfo";
            this.Picchageinfo.ShadowDecoration.BorderRadius = 50;
            this.Picchageinfo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Picchageinfo.ShadowDecoration.Parent = this.Picchageinfo;
            this.Picchageinfo.Size = new System.Drawing.Size(95, 95);
            this.Picchageinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picchageinfo.TabIndex = 23;
            this.Picchageinfo.TabStop = false;
            // 
            // btnchangeinfo
            // 
            this.btnchangeinfo.BorderRadius = 12;
            this.btnchangeinfo.CheckedState.Parent = this.btnchangeinfo;
            this.btnchangeinfo.CustomImages.Parent = this.btnchangeinfo;
            this.btnchangeinfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.btnchangeinfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnchangeinfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangeinfo.ForeColor = System.Drawing.Color.White;
            this.btnchangeinfo.HoverState.Parent = this.btnchangeinfo;
            this.btnchangeinfo.Location = new System.Drawing.Point(266, 401);
            this.btnchangeinfo.Name = "btnchangeinfo";
            this.btnchangeinfo.ShadowDecoration.Parent = this.btnchangeinfo;
            this.btnchangeinfo.Size = new System.Drawing.Size(120, 45);
            this.btnchangeinfo.TabIndex = 26;
            this.btnchangeinfo.Text = "Change";
            this.btnchangeinfo.Click += new System.EventHandler(this.btnchangeinfo_Click);
            // 
            // profilControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnchangeinfo);
            this.Controls.Add(this.btnloadpic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Picchageinfo);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputconfirm);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "profilControl";
            this.Size = new System.Drawing.Size(689, 466);
            this.Load += new System.EventHandler(this.profilControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picchageinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox inputconfirm;
        private Guna.UI2.WinForms.Guna2TextBox inputPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox inputName;
        private Guna.UI2.WinForms.Guna2TextBox inputemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnloadpic;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Picchageinfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnchangeinfo;
    }
}
