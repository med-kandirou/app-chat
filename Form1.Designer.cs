
namespace app_chat
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.entetePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.gunasignup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunalogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.entetePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.entetePanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // entetePanel
            // 
            this.entetePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entetePanel.BackgroundImage")));
            this.entetePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entetePanel.Controls.Add(this.btnclose);
            this.entetePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.entetePanel.GradientBottomRight = System.Drawing.Color.White;
            this.entetePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.entetePanel.GradientTopRight = System.Drawing.Color.White;
            this.entetePanel.Location = new System.Drawing.Point(0, 0);
            this.entetePanel.Name = "entetePanel";
            this.entetePanel.Quality = 10;
            this.entetePanel.Size = new System.Drawing.Size(813, 29);
            this.entetePanel.TabIndex = 7;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BorderThickness = 2;
            this.btnclose.CheckedState.Parent = this.btnclose;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.CustomImages.Parent = this.btnclose;
            this.btnclose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(31)))), ((int)(((byte)(52)))));
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.Location = new System.Drawing.Point(781, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(19, 19);
            this.btnclose.TabIndex = 0;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // loginpanel
            // 
            this.loginpanel.Location = new System.Drawing.Point(0, 72);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(811, 430);
            this.loginpanel.TabIndex = 8;
            // 
            // gunasignup
            // 
            this.gunasignup.CheckedState.Parent = this.gunasignup;
            this.gunasignup.CustomImages.Parent = this.gunasignup;
            this.gunasignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gunasignup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(116)))));
            this.gunasignup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunasignup.ForeColor = System.Drawing.Color.White;
            this.gunasignup.HoverState.Parent = this.gunasignup;
            this.gunasignup.Location = new System.Drawing.Point(405, 29);
            this.gunasignup.Name = "gunasignup";
            this.gunasignup.ShadowDecoration.Parent = this.gunasignup;
            this.gunasignup.Size = new System.Drawing.Size(406, 45);
            this.gunasignup.TabIndex = 9;
            this.gunasignup.Text = "Sign Up";
            this.gunasignup.Click += new System.EventHandler(this.gunasignup_Click);
            // 
            // gunalogin
            // 
            this.gunalogin.CheckedState.Parent = this.gunalogin;
            this.gunalogin.CustomImages.Parent = this.gunalogin;
            this.gunalogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(17)))));
            this.gunalogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(92)))));
            this.gunalogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunalogin.ForeColor = System.Drawing.Color.White;
            this.gunalogin.HoverState.Parent = this.gunalogin;
            this.gunalogin.Location = new System.Drawing.Point(0, 29);
            this.gunalogin.Name = "gunalogin";
            this.gunalogin.ShadowDecoration.Parent = this.gunalogin;
            this.gunalogin.Size = new System.Drawing.Size(406, 45);
            this.gunalogin.TabIndex = 10;
            this.gunalogin.Text = "Login";
            this.gunalogin.Click += new System.EventHandler(this.gunalogin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 503);
            this.Controls.Add(this.gunalogin);
            this.Controls.Add(this.gunasignup);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.entetePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.entetePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel entetePanel;
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private System.Windows.Forms.Panel loginpanel;
        private Guna.UI2.WinForms.Guna2GradientButton gunalogin;
        private Guna.UI2.WinForms.Guna2GradientButton gunasignup;
        private System.Windows.Forms.Timer timer1;
    }
}

