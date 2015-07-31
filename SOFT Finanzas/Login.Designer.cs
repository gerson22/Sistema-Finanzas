namespace SOFT_Finanzas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuEmp = new MetroFramework.Controls.MetroTextBox();
            this.conEmp = new MetroFramework.Controls.MetroTextBox();
            this.btnLog = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // usuEmp
            // 
            this.usuEmp.Location = new System.Drawing.Point(157, 127);
            this.usuEmp.MaxLength = 45;
            this.usuEmp.Name = "usuEmp";
            this.usuEmp.PromptText = "USUARIO";
            this.usuEmp.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.usuEmp.Size = new System.Drawing.Size(205, 35);
            this.usuEmp.Style = MetroFramework.MetroColorStyle.Blue;
            this.usuEmp.TabIndex = 1;
            this.usuEmp.UseStyleColors = true;
            // 
            // conEmp
            // 
            this.conEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conEmp.Location = new System.Drawing.Point(157, 193);
            this.conEmp.MaxLength = 45;
            this.conEmp.Multiline = true;
            this.conEmp.Name = "conEmp";
            this.conEmp.PasswordChar = '+';
            this.conEmp.PromptText = "CONTRASEÑA";
            this.conEmp.Size = new System.Drawing.Size(205, 35);
            this.conEmp.TabIndex = 3;
            this.conEmp.Theme = MetroFramework.MetroThemeStyle.Light;
            this.conEmp.UseStyleColors = true;
            this.conEmp.Click += new System.EventHandler(this.conEmp_Click);
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLog.Location = new System.Drawing.Point(336, 243);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(117, 41);
            this.btnLog.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Ingresar";
            this.btnLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SOFT_Finanzas.Properties.Resources.logo_marti;
            this.pictureBox3.Location = new System.Drawing.Point(0, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(506, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.usuEmp);
            this.Controls.Add(this.conEmp);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Enter += new System.EventHandler(this.Login_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usuEmp;
        private MetroFramework.Controls.MetroTextBox conEmp;
        private MetroFramework.Controls.MetroButton btnLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}