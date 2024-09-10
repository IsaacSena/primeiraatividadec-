namespace Cadastro_De_Pilantra.View
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            tbx_email = new TextBox();
            tbx_senha = new TextBox();
            EntrarLogin = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(626, 255);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 1;
            label1.Text = "Entre com sua conta institucional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 294);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 329);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(603, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(599, 358);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Manter-me logado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(736, 358);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueceu a senha?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(598, 291);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(244, 23);
            tbx_email.TabIndex = 8;
            // 
            // tbx_senha
            // 
            tbx_senha.Location = new Point(598, 326);
            tbx_senha.Name = "tbx_senha";
            tbx_senha.Size = new Size(244, 23);
            tbx_senha.TabIndex = 9;
            // 
            // EntrarLogin
            // 
            EntrarLogin.Location = new Point(599, 392);
            EntrarLogin.Name = "EntrarLogin";
            EntrarLogin.Size = new Size(82, 30);
            EntrarLogin.TabIndex = 11;
            EntrarLogin.Text = "Entrar";
            EntrarLogin.UseVisualStyleBackColor = true;
            EntrarLogin.Click += EntrarLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(519, 550);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(922, 550);
            Controls.Add(pictureBox2);
            Controls.Add(EntrarLogin);
            Controls.Add(tbx_senha);
            Controls.Add(tbx_email);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private TextBox tbx_email;
        private TextBox tbx_senha;
        private Button EntrarLogin;
        private PictureBox pictureBox2;
    }
}