namespace SistemasVentas.VISTA.PresentacionVista
{
    partial class LoginVistas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnlogin = new Button();
            txtpass = new TextBox();
            btnCerrar = new PictureBox();
            txtuser = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chartreuse;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 309);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.market_upds;
            pictureBox1.Location = new Point(39, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(412, 29);
            label1.Name = "label1";
            label1.Size = new Size(180, 29);
            label1.TabIndex = 1;
            label1.Text = "INICIAR SESION";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Teal;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.Black;
            btnlogin.Location = new Point(434, 261);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(106, 36);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Ingresar";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(26, 32, 40);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.Lime;
            txtpass.Location = new Point(340, 187);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(295, 19);
            txtpass.TabIndex = 7;
            txtpass.Text = "Password";
            txtpass.TextChanged += txtpass_TextChanged;
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Imagen11;
            btnCerrar.Location = new Point(626, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 8;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(26, 32, 40);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.Lime;
            txtuser.Location = new Point(340, 117);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(295, 19);
            txtuser.TabIndex = 9;
            txtuser.Text = "Usuario";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // LoginVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(663, 309);
            Controls.Add(txtuser);
            Controls.Add(btnCerrar);
            Controls.Add(txtpass);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginVistas";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginVistas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnlogin;
        private TextBox txtpass;
        private PictureBox btnCerrar;
        private TextBox txtuser;
    }
}