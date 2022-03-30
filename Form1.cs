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

        public void hideTab(TabPage unOnglet)
        {
            unOnglet.Enabled = false;
            unOnglet.Visible = false;
        }

        private void btn_redirec_AzureBDDPerso_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tab_login;
            step = tab_login;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (step != tabControl.SelectedTab)
            {
                tabControl.SelectTab(step.Name);
            }
        }

        private void input_mail_Enter(object sender, EventArgs e)
        {

        }

        private void input_mail_Leave(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabControl.SelectedTab.TabIndex - 1);
            step = tabControl.SelectedTab;
        }
    }
}
