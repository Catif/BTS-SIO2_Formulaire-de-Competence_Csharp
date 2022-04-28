
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label34;
            System.Windows.Forms.Label label33;
            System.Windows.Forms.Label label32;
            System.Windows.Forms.Label label31;
            System.Windows.Forms.Label label30;
            System.Windows.Forms.Label label29;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label label23;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_choiceBDD = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_redirec_AzureBDDPerso = new System.Windows.Forms.Button();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.text_errorLogin = new System.Windows.Forms.Label();
            this.btn_return_login = new System.Windows.Forms.Button();
            this.input_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.input_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_ShowCompetence = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl_Skills = new System.Windows.Forms.TabControl();
            this.tabSkills_Competence = new System.Windows.Forms.TabPage();
            this.dataGrid_Competence = new System.Windows.Forms.DataGridView();
            this.N_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libel_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSkills_Savoir = new System.Windows.Forms.TabPage();
            this.dataGrid_Savoir = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSkills_Indicateur = new System.Windows.Forms.TabPage();
            this.dataGrid_Indicateur = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_return_skills = new System.Windows.Forms.Button();
            this.tab_Apropos = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tab_choiceBDD.SuspendLayout();
            this.tab_login.SuspendLayout();
            this.tab_ShowCompetence.SuspendLayout();
            this.tabControl_Skills.SuspendLayout();
            this.tabSkills_Competence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Competence)).BeginInit();
            this.tabSkills_Savoir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Savoir)).BeginInit();
            this.tabSkills_Indicateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Indicateur)).BeginInit();
            this.tab_Apropos.SuspendLayout();
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
            this.tabControl.TabStop = false;
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
            this.tab_login.Controls.Add(this.text_errorLogin);
            this.tab_login.Controls.Add(this.btn_return_login);
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
            // text_errorLogin
            // 
            this.text_errorLogin.BackColor = System.Drawing.Color.Transparent;
            this.text_errorLogin.Font = new System.Drawing.Font("Gadugi", 12F);
            this.text_errorLogin.ForeColor = System.Drawing.Color.White;
            this.text_errorLogin.Location = new System.Drawing.Point(200, 33);
            this.text_errorLogin.Name = "text_errorLogin";
            this.text_errorLogin.Size = new System.Drawing.Size(400, 50);
            this.text_errorLogin.TabIndex = 5;
            this.text_errorLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_return_login.TabIndex = 1;
            this.btn_return_login.Text = "<";
            this.btn_return_login.UseVisualStyleBackColor = false;
            this.btn_return_login.Click += new System.EventHandler(this.btn_return_login_Click);
            // 
            // input_password
            // 
            this.input_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.input_password.Location = new System.Drawing.Point(200, 234);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(400, 29);
            this.input_password.TabIndex = 3;
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
            this.btn_login.Location = new System.Drawing.Point(250, 269);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(300, 33);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Connexion";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // input_mail
            // 
            this.input_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.input_mail.Location = new System.Drawing.Point(200, 199);
            this.input_mail.Name = "input_mail";
            this.input_mail.Size = new System.Drawing.Size(400, 29);
            this.input_mail.TabIndex = 2;
            this.input_mail.Text = "Email professionel";
            this.input_mail.Enter += new System.EventHandler(this.input_mail_Enter);
            this.input_mail.Leave += new System.EventHandler(this.input_mail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 138);
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
            this.label4.Location = new System.Drawing.Point(306, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Page de connexion";
            // 
            // tab_ShowCompetence
            // 
            this.tab_ShowCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tab_ShowCompetence.Controls.Add(this.label5);
            this.tab_ShowCompetence.Controls.Add(this.tabControl_Skills);
            this.tab_ShowCompetence.Controls.Add(this.btn_return_skills);
            this.tab_ShowCompetence.Location = new System.Drawing.Point(4, 38);
            this.tab_ShowCompetence.Name = "tab_ShowCompetence";
            this.tab_ShowCompetence.Size = new System.Drawing.Size(792, 408);
            this.tab_ShowCompetence.TabIndex = 2;
            this.tab_ShowCompetence.Text = "3. Affichage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Voici les Compétences, Savoirs et Indicateur !";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl_Skills
            // 
            this.tabControl_Skills.Controls.Add(this.tabSkills_Competence);
            this.tabControl_Skills.Controls.Add(this.tabSkills_Savoir);
            this.tabControl_Skills.Controls.Add(this.tabSkills_Indicateur);
            this.tabControl_Skills.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl_Skills.Location = new System.Drawing.Point(-4, 73);
            this.tabControl_Skills.Name = "tabControl_Skills";
            this.tabControl_Skills.Padding = new System.Drawing.Point(60, 3);
            this.tabControl_Skills.SelectedIndex = 0;
            this.tabControl_Skills.Size = new System.Drawing.Size(800, 339);
            this.tabControl_Skills.TabIndex = 3;
            // 
            // tabSkills_Competence
            // 
            this.tabSkills_Competence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabSkills_Competence.Controls.Add(this.dataGrid_Competence);
            this.tabSkills_Competence.ForeColor = System.Drawing.Color.Black;
            this.tabSkills_Competence.Location = new System.Drawing.Point(4, 29);
            this.tabSkills_Competence.Name = "tabSkills_Competence";
            this.tabSkills_Competence.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills_Competence.Size = new System.Drawing.Size(792, 306);
            this.tabSkills_Competence.TabIndex = 0;
            this.tabSkills_Competence.Text = "Compétence";
            // 
            // dataGrid_Competence
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Competence.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGrid_Competence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGrid_Competence.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Competence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGrid_Competence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Item,
            this.Libel_Item});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Competence.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGrid_Competence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Competence.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Competence.Name = "dataGrid_Competence";
            this.dataGrid_Competence.Size = new System.Drawing.Size(786, 300);
            this.dataGrid_Competence.TabIndex = 0;
            // 
            // N_Item
            // 
            this.N_Item.HeaderText = "N°Item";
            this.N_Item.Name = "N_Item";
            this.N_Item.Width = 83;
            // 
            // Libel_Item
            // 
            this.Libel_Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libel_Item.HeaderText = "Libelé de l\'item";
            this.Libel_Item.Name = "Libel_Item";
            // 
            // tabSkills_Savoir
            // 
            this.tabSkills_Savoir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabSkills_Savoir.Controls.Add(this.dataGrid_Savoir);
            this.tabSkills_Savoir.ForeColor = System.Drawing.Color.Black;
            this.tabSkills_Savoir.Location = new System.Drawing.Point(4, 29);
            this.tabSkills_Savoir.Name = "tabSkills_Savoir";
            this.tabSkills_Savoir.Size = new System.Drawing.Size(792, 306);
            this.tabSkills_Savoir.TabIndex = 1;
            this.tabSkills_Savoir.Text = "Savoir";
            // 
            // dataGrid_Savoir
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Savoir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGrid_Savoir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGrid_Savoir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Savoir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGrid_Savoir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Savoir.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGrid_Savoir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Savoir.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Savoir.Name = "dataGrid_Savoir";
            this.dataGrid_Savoir.Size = new System.Drawing.Size(792, 306);
            this.dataGrid_Savoir.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N° Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Libélé de l\'Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabSkills_Indicateur
            // 
            this.tabSkills_Indicateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabSkills_Indicateur.Controls.Add(this.dataGrid_Indicateur);
            this.tabSkills_Indicateur.ForeColor = System.Drawing.Color.Black;
            this.tabSkills_Indicateur.Location = new System.Drawing.Point(4, 29);
            this.tabSkills_Indicateur.Name = "tabSkills_Indicateur";
            this.tabSkills_Indicateur.Size = new System.Drawing.Size(792, 306);
            this.tabSkills_Indicateur.TabIndex = 2;
            this.tabSkills_Indicateur.Text = "Indicateur";
            // 
            // dataGrid_Indicateur
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Indicateur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGrid_Indicateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGrid_Indicateur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Indicateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dataGrid_Indicateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Indicateur.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataGrid_Indicateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Indicateur.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Indicateur.Name = "dataGrid_Indicateur";
            this.dataGrid_Indicateur.Size = new System.Drawing.Size(792, 306);
            this.dataGrid_Indicateur.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "N° Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 87;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Libélé de l\'Item";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btn_return_skills
            // 
            this.btn_return_skills.AutoSize = true;
            this.btn_return_skills.BackColor = System.Drawing.Color.White;
            this.btn_return_skills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return_skills.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.btn_return_skills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btn_return_skills.Location = new System.Drawing.Point(8, 6);
            this.btn_return_skills.Name = "btn_return_skills";
            this.btn_return_skills.Size = new System.Drawing.Size(39, 34);
            this.btn_return_skills.TabIndex = 2;
            this.btn_return_skills.Text = "<";
            this.btn_return_skills.UseVisualStyleBackColor = false;
            this.btn_return_skills.Click += new System.EventHandler(this.btn_return_skills_Click);
            // 
            // tab_Apropos
            // 
            this.tab_Apropos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tab_Apropos.Controls.Add(label34);
            this.tab_Apropos.Controls.Add(label33);
            this.tab_Apropos.Controls.Add(label32);
            this.tab_Apropos.Controls.Add(label31);
            this.tab_Apropos.Controls.Add(label30);
            this.tab_Apropos.Controls.Add(label29);
            this.tab_Apropos.Controls.Add(label28);
            this.tab_Apropos.Controls.Add(label23);
            this.tab_Apropos.Controls.Add(this.label17);
            this.tab_Apropos.Location = new System.Drawing.Point(4, 38);
            this.tab_Apropos.Name = "tab_Apropos";
            this.tab_Apropos.Size = new System.Drawing.Size(792, 408);
            this.tab_Apropos.TabIndex = 3;
            this.tab_Apropos.Text = "A propos";
            // 
            // label34
            // 
            label34.BackColor = System.Drawing.Color.Transparent;
            label34.Font = new System.Drawing.Font("Segoe UI", 16F);
            label34.ForeColor = System.Drawing.Color.WhiteSmoke;
            label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label34.Location = new System.Drawing.Point(438, 305);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(242, 32);
            label34.TabIndex = 57;
            label34.Text = "28/04/2022";
            // 
            // label33
            // 
            label33.BackColor = System.Drawing.Color.Transparent;
            label33.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.ForeColor = System.Drawing.Color.White;
            label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label33.Location = new System.Drawing.Point(50, 305);
            label33.Name = "label33";
            label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label33.Size = new System.Drawing.Size(382, 32);
            label33.TabIndex = 56;
            label33.Text = "Date de sortie de la version :";
            label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            label32.BackColor = System.Drawing.Color.Transparent;
            label32.Font = new System.Drawing.Font("Segoe UI", 16F);
            label32.ForeColor = System.Drawing.Color.WhiteSmoke;
            label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label32.Location = new System.Drawing.Point(438, 255);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(242, 32);
            label32.TabIndex = 55;
            label32.Text = "1.0";
            // 
            // label31
            // 
            label31.BackColor = System.Drawing.Color.Transparent;
            label31.Font = new System.Drawing.Font("Segoe UI", 16F);
            label31.ForeColor = System.Drawing.Color.WhiteSmoke;
            label31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label31.Location = new System.Drawing.Point(438, 205);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(242, 32);
            label31.TabIndex = 54;
            label31.Text = "BTS SIO2 SLAM";
            // 
            // label30
            // 
            label30.BackColor = System.Drawing.Color.Transparent;
            label30.Font = new System.Drawing.Font("Segoe UI", 16F);
            label30.ForeColor = System.Drawing.Color.WhiteSmoke;
            label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label30.Location = new System.Drawing.Point(438, 155);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(242, 32);
            label30.TabIndex = 53;
            label30.Text = "Bradley BARBIER";
            // 
            // label29
            // 
            label29.BackColor = System.Drawing.Color.Transparent;
            label29.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.ForeColor = System.Drawing.Color.White;
            label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label29.Location = new System.Drawing.Point(50, 255);
            label29.Name = "label29";
            label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label29.Size = new System.Drawing.Size(382, 32);
            label29.TabIndex = 52;
            label29.Text = "Version de ce magnifique logiciel :";
            label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            label28.BackColor = System.Drawing.Color.Transparent;
            label28.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.ForeColor = System.Drawing.Color.White;
            label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label28.Location = new System.Drawing.Point(50, 205);
            label28.Name = "label28";
            label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label28.Size = new System.Drawing.Size(382, 32);
            label28.TabIndex = 51;
            label28.Text = "Classe de ce magnifique créateur :";
            label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.BackColor = System.Drawing.Color.Transparent;
            label23.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.ForeColor = System.Drawing.Color.White;
            label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label23.Location = new System.Drawing.Point(50, 155);
            label23.Name = "label23";
            label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label23.Size = new System.Drawing.Size(382, 32);
            label23.TabIndex = 50;
            label23.Text = "Créateur de ce magnifique logiciel :";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(48, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(691, 64);
            this.label17.TabIndex = 49;
            this.label17.Text = "A propos";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tab_ShowCompetence.ResumeLayout(false);
            this.tab_ShowCompetence.PerformLayout();
            this.tabControl_Skills.ResumeLayout(false);
            this.tabSkills_Competence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Competence)).EndInit();
            this.tabSkills_Savoir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Savoir)).EndInit();
            this.tabSkills_Indicateur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Indicateur)).EndInit();
            this.tab_Apropos.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_return_login;
        private System.Windows.Forms.Label text_errorLogin;
        private System.Windows.Forms.Button btn_return_skills;
        private System.Windows.Forms.TabControl tabControl_Skills;
        private System.Windows.Forms.TabPage tabSkills_Competence;
        private System.Windows.Forms.DataGridView dataGrid_Competence;
        private System.Windows.Forms.TabPage tabSkills_Savoir;
        private System.Windows.Forms.DataGridView dataGrid_Savoir;
        private System.Windows.Forms.TabPage tabSkills_Indicateur;
        private System.Windows.Forms.DataGridView dataGrid_Indicateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libel_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label17;
    }
}

