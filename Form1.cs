using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void setPlaceHolder(TextBox input, string placeHolder, bool entrer)
        {
            if (entrer)
            {
                if (input.Text == placeHolder)
                {
                    input.Text = "";
                    input.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }
            else
            {
                if (input.Text == "")
                {
                    input.Text = placeHolder;
                    input.ForeColor = Color.FromArgb(117, 117, 117);
                }
            }
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
            setPlaceHolder(input_mail, "Email professionel", true);
        }

        private void input_mail_Leave(object sender, EventArgs e)
        {
            setPlaceHolder(input_mail, "Email professionel", false);
        }

        private void input_password_Enter(object sender, EventArgs e)
        {
            setPlaceHolder(input_password, "Mot de passe", true);
        }

        private void input_password_Leave(object sender, EventArgs e)
        {
            setPlaceHolder(input_password, "Mot de passe", false);
        }

        private void btn_return_login_Click(object sender, EventArgs e)
        {
            changeSelectedTab(tab_choiceBDD);
        }
    }
}
