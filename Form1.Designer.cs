
namespace Formulaire_de_Competence
{
    partial class Form
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_choiceBDD = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_redirec_AzureBDDPerso = new System.Windows.Forms.Button();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.btn_return_login = new System.Windows.Forms.Button();
            this.btn_ForgetPassword = new System.Windows.Forms.Button();
            this.input_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.input_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_ShowCompetence = new System.Windows.Forms.TabPage();
            this.tab_Apropos = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tab_choiceBDD.SuspendLayout();
            this.tab_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_choiceBDD);
            this.tabControl.Controls.Add(this.tab_login);
            this.tabControl.Controls.Add(this.tab_ShowCompetence);
            this.tabControl.Controls.Add(this.tab_Apropos);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(30, 8);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab_choiceBDD
            // 
            this.tab_choiceBDD.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.tab_choiceBDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tab_choiceBDD.Controls.Add(this.button3);
            this.tab_choiceBDD.Controls.Add(this.button2);
            this.tab_choiceBDD.Controls.Add(this.button1);
            this.tab_choiceBDD.Controls.Add(this.label2);
            this.tab_choiceBDD.Controls.Add(this.label1);
            this.tab_choiceBDD.Controls.Add(this.btn_redirec_AzureBDDPerso);
            this.tab_choiceBDD.Cursor = System.Windows.Forms.Cursors.Default;
            this.tab_choiceBDD.ForeColor = System.Drawing.SystemColors.Window;
            this.tab_choiceBDD.Location = new System.Drawing.Point(4, 38);
            this.tab_choiceBDD.Name = "tab_choiceBDD";
            this.tab_choiceBDD.Padding = new System.Windows.Forms.Padding(3);
            this.tab_choiceBDD.Size = new System.Drawing.Size(792, 408);
            this.tab_choiceBDD.TabIndex = 0;
            this.tab_choiceBDD.Text = "1. Choix BDD";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.No;
            this.button3.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button3.Location = new System.Drawing.Point(240, 325);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.button3.Size = new System.Drawing.Size(300, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "------------------";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button2.Location = new System.Drawing.Point(240, 265);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.button2.Size = new System.Drawing.Size(300, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "------------------";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.Location = new System.Drawing.Point(240, 205);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.button1.Size = new System.Drawing.Size(300, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "------------------";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ce logiciel conteint la liste des compétences devant être acquise au cours du BTS" +
    " SIO.\r\nSi vous possédez un compte, vous pouvez vous connecter avec le bouton ci-" +
    "dessous.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue sur le Portefeuille de Compétence du BTS SIO !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_redirec_AzureBDDPerso
            // 
            this.btn_redirec_AzureBDDPerso.AutoSize = true;
            this.btn_redirec_AzureBDDPerso.BackColor = System.Drawing.Color.White;
            this.btn_redirec_AzureBDDPerso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_redirec_AzureBDDPerso.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.btn_redirec_AzureBDDPerso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btn_redirec_AzureBDDPerso.Location = new System.Drawing.Point(240, 145);
            this.btn_redirec_AzureBDDPerso.Name = "btn_redirec_AzureBDDPerso";
            this.btn_redirec_AzureBDDPerso.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.btn_redirec_AzureBDDPerso.Size = new System.Drawing.Size(300, 54);
            this.btn_redirec_AzureBDDPerso.TabIndex = 0;
            this.btn_redirec_AzureBDDPerso.Text = "BDD Azure Perso";
            this.btn_redirec_AzureBDDPerso.UseVisualStyleBackColor = false;
            this.btn_redirec_AzureBDDPerso.Click += new System.EventHandler(this.btn_redirec_AzureBDDPerso_Click);
            // 
            // tab_login
            // 
            this.tab_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tab_login.Controls.Add(this.btn_return_login);
            this.tab_login.Controls.Add(this.btn_ForgetPassword);
            this.tab_login.Controls.Add(this.input_password);
            this.tab_login.Controls.Add(this.btn_login);
            this.tab_login.Controls.Add(this.input_mail);
            this.tab_login.Controls.Add(this.label3);
            this.tab_login.Controls.Add(this.label4);
            this.tab_login.Location = new System.Drawing.Point(4, 38);
            this.tab_login.Name = "tab_login";
            this.tab_login.Padding = new System.Windows.Forms.Padding(3);
            this.tab_login.Size = new System.Drawing.Size(792, 408);
            this.tab_login.TabIndex = 1;
            this.tab_login.Text = "2. Connexion";
            // 
            // btn_return_login
            // 
            this.btn_return_login.AutoSize = true;
            this.btn_return_login.BackColor = System.Drawing.Color.White;
            this.btn_return_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return_login.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.btn_return_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btn_return_login.Location = new System.Drawing.Point(8, 6);
            this.btn_return_login.Name = "btn_return_login";
            this.btn_return_login.Size = new System.Drawing.Size(39, 34);
            this.btn_return_login.TabIndex = 9;
            this.btn_return_login.Text = "<";
            this.btn_return_login.UseVisualStyleBackColor = false;
            this.btn_return_login.Click += new System.EventHandler(this.btn_return_login_Click);
            // 
            // btn_ForgetPassword
            // 
            this.btn_ForgetPassword.AutoSize = true;
            this.btn_ForgetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_ForgetPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_ForgetPassword.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_ForgetPassword.Location = new System.Drawing.Point(250, 284);
            this.btn_ForgetPassword.Name = "btn_ForgetPassword";
            this.btn_ForgetPassword.Size = new System.Drawing.Size(300, 33);
            this.btn_ForgetPassword.TabIndex = 8;
            this.btn_ForgetPassword.Text = "Mot de passe oublié";
            this.btn_ForgetPassword.UseVisualStyleBackColor = false;
            // 
            // input_password
            // 
            this.input_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.input_password.Location = new System.Drawing.Point(200, 210);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(400, 29);
            this.input_password.TabIndex = 7;
            this.input_password.Text = "Mot de passe";
            this.input_password.Enter += new System.EventHandler(this.input_password_Enter);
            this.input_password.Leave += new System.EventHandler(this.input_password_Leave);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btn_login.Location = new System.Drawing.Point(250, 245);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(300, 33);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Connexion";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // input_mail
            // 
            this.input_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.input_mail.Location = new System.Drawing.Point(200, 175);
            this.input_mail.Name = "input_mail";
            this.input_mail.Size = new System.Drawing.Size(400, 29);
            this.input_mail.TabIndex = 5;
            this.input_mail.Text = "Email professionel";
            this.input_mail.Enter += new System.EventHandler(this.input_mail_Enter);
            this.input_mail.Leave += new System.EventHandler(this.input_mail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(713, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pour vous connecter, rien de plus simple !\r\nUtilisez votre email professionel et " +
    "si c\'est votre première connexion, utilisez comme mot de passe sio.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(306, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Page de connexion";
            // 
            // tab_ShowCompetence
            // 
            this.tab_ShowCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tab_ShowCompetence.Location = new System.Drawing.Point(4, 38);
            this.tab_ShowCompetence.Name = "tab_ShowCompetence";
            this.tab_ShowCompetence.Size = new System.Drawing.Size(792, 408);
            this.tab_ShowCompetence.TabIndex = 2;
            this.tab_ShowCompetence.Text = "3. Affichage";
            // 
            // tab_Apropos
            // 
            this.tab_Apropos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tab_Apropos.Location = new System.Drawing.Point(4, 38);
            this.tab_Apropos.Name = "tab_Apropos";
            this.tab_Apropos.Size = new System.Drawing.Size(792, 408);
            this.tab_Apropos.TabIndex = 3;
            this.tab_Apropos.Text = "A propos";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulaire de Compétence - Bradley BARBIER";
            this.tabControl.ResumeLayout(false);
            this.tab_choiceBDD.ResumeLayout(false);
            this.tab_choiceBDD.PerformLayout();
            this.tab_login.ResumeLayout(false);
            this.tab_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_choiceBDD;
        private System.Windows.Forms.TabPage tab_login;
        private System.Windows.Forms.TabPage tab_ShowCompetence;
        private System.Windows.Forms.TabPage tab_Apropos;
        private System.Windows.Forms.Button btn_redirec_AzureBDDPerso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_mail;
        private System.Windows.Forms.Button btn_ForgetPassword;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_return_login;
    }
}

