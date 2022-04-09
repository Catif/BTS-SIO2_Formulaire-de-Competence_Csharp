using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BC = BCrypt.Net.BCrypt;

namespace Formulaire_de_Competence
{
    public partial class Form : System.Windows.Forms.Form
    {
        private TabPage step;
        private SqlConnection BDD;
        private String BDDChoice;
        private SqlDataReader dataReader;

        private Nullable<int> idUser;


        public Form()
        {
            InitializeComponent();
            step = tabControl.SelectedTab;
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab != tab_Apropos)
            {
                if (step != tabControl.SelectedTab)
                {
                    tabControl.SelectTab(step.Name);
                }
            }
        }







        #region Functions
            private void changeSelectedTab(TabPage unOnglet)
            {
                this.step = unOnglet;
                tabControl.SelectedTab = unOnglet;
            }

            private void setPlaceHolder(TextBox input, string placeHolder, bool password, bool entrer)
            {
                if (entrer)
                {
                    if (input.Text == placeHolder)
                    {
                        input.Text = "";
                        input.ForeColor = Color.FromArgb(0, 0, 0);

                        if(password)
                            input.PasswordChar = '*';
                    }
                }
                else
                {
                    if (input.Text == "")
                    {
                        if(password)
                            input.PasswordChar = '\0';

                        input.Text = placeHolder;
                        input.ForeColor = Color.FromArgb(117, 117, 117);
                    }
                }
            }

            private bool ValidMail(string mail_address)
            {
                Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
                return myRegex.IsMatch(mail_address);
            }
        #endregion


        #region tabControl
            #region ChoixBDD
                private void btn_redirec_AzureBDDPerso_Click(object sender, EventArgs e)
                {
                    BDD = new SqlConnection(@"Data Source=catif1-euw.database.windows.net;Initial Catalog=Bradley-BARBIER_Competence;User ID=readerOnlyDataSQL;Password=M0t2p4ssPU1SS4NT");
                    BDD.Open();
                    BDDChoice = "AzureBDDPerso";
                    changeSelectedTab(tab_login);
                }
        #endregion

            #region Connexion
                #region input
                    private void input_mail_Enter(object sender, EventArgs e)
                    {
                        setPlaceHolder(input_mail, "Email professionel", false, true);
                    }

                    private void input_mail_Leave(object sender, EventArgs e)
                    {
                        setPlaceHolder(input_mail, "Email professionel", false, false);
                    }

                    private void input_password_Enter(object sender, EventArgs e)
                    {
                        setPlaceHolder(input_password, "Mot de passe", true, true);
                    }

                    private void input_password_Leave(object sender, EventArgs e)
                    {
                        setPlaceHolder(input_password, "Mot de passe", true, false);
                    }
        #endregion

                #region button
                    private void btn_return_login_Click(object sender, EventArgs e)
                    {
                        BDD.Close();
                        BDDChoice = "";
                        BDD = new SqlConnection(@"");
                        changeSelectedTab(tab_choiceBDD);
                        input_mail.Text = "";
                        input_password.Text = "";
                        setPlaceHolder(input_mail, "Email professionel", false, false);
                        setPlaceHolder(input_password, "Mot de passe", true, false);
                    }


                    private void btn_login_Click(object sender, EventArgs e)
                    {
                        text_errorLogin.Text = "";
                        text_errorLogin.BackColor = Color.Transparent;
                        if (input_mail.Text != "Email professionel" || input_password.PasswordChar == '*')
                        {
                            if (ValidMail(input_mail.Text))
                            {
                                SqlCommand command = new SqlCommand("", BDD);

                                command.CommandText = "SELECT * FROM etudiant WHERE mail_etud = @mail";
                                SqlParameter mailParameter = new SqlParameter("@mail", SqlDbType.NVarChar, 100);

                                mailParameter.Value = input_mail.Text;
                                command.Parameters.Add(mailParameter);
                                command.Prepare();

                                using (dataReader = command.ExecuteReader())
                                {
                                    dataReader.Read();
                                    try
                                    {
                                        if (BC.Verify(input_password.Text, dataReader.GetString(dataReader.GetOrdinal("MOT_DE_PASSE_ETUD"))))
                                        {
                                            idUser = dataReader.GetInt32(dataReader.GetOrdinal("IDENTIFIANT_ETUD"));
                                            changeSelectedTab(tab_ShowCompetence);
                                            input_mail.Text = "";
                                            input_password.Text = "";
                                            setPlaceHolder(input_mail, "Email professionel", false, false);
                                            setPlaceHolder(input_password, "Mot de passe", true, false);
                                        }
                                        else
                                        {
                                            text_errorLogin.Text = "L'email ou le mot de passe est invalide.";
                                            text_errorLogin.BackColor = Color.FromArgb(144, 0, 0);
                                            input_password.Text = "";
                                            setPlaceHolder(input_password, "Mot de passe", true, false);
                                        }
                                    }
                                    catch( Exception)
                                    {
                                        text_errorLogin.Text = "L'email ou le mot de passe est invalide.";
                                        text_errorLogin.BackColor = Color.FromArgb(144, 0, 0);
                                        input_password.Text = "";
                                        setPlaceHolder(input_password, "Mot de passe", true, false);
                                    }
                                }
                            }
                            else
                            {
                                text_errorLogin.Text = "L'email n'est pas valide.";
                                text_errorLogin.BackColor = Color.FromArgb(144, 0, 0);
                                input_password.Text = "";
                                setPlaceHolder(input_password, "Mot de passe", true, false);
                            }
                        } 
                        else
                        {
                            text_errorLogin.Text = "Les champs ne sont pas tous remplis.";
                            text_errorLogin.BackColor = Color.FromArgb(144, 0, 0);
                            input_password.Text = "";
                            setPlaceHolder(input_password, "Mot de passe", true, false);
                        }
                    }


                #endregion

                #region Affichage
                    private void btn_return_skills_Click(object sender, EventArgs e)
                    {
                        changeSelectedTab(tab_login);
                        idUser = null;
                    }
                #endregion

            #endregion

        #endregion


    }
}
