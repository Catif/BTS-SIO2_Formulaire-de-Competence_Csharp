using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Formulaire_de_Competence
{
    public partial class Form : System.Windows.Forms.Form
    {
        private TabPage step;

        public Form()
        {
            InitializeComponent();
            step = tabControl.SelectedTab;
        }

        public void changeSelectedTab(TabPage unOnglet)
        {
            this.step = unOnglet;
            tabControl.SelectedTab = unOnglet;
        }

        public void setPlaceHolder(TextBox input, string placeHolder, bool password, bool entrer)
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

        private void btn_redirec_AzureBDDPerso_Click(object sender, EventArgs e)
        {
            changeSelectedTab(tab_login);
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (ValidMail(input_mail.Text) && input_password.Text != null)
            {

            }
        }

        private void btn_return_login_Click(object sender, EventArgs e)
        {
            changeSelectedTab(tab_choiceBDD);
        }
    }
}
