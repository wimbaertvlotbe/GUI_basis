using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI_basis
{
    public partial class Form1 : Form
    {
        List<Persoon> personen = new List<Persoon>();
        public Form1()
        {
            InitializeComponent();
            ToolTip idTip = new ToolTip();
            idTip.SetToolTip(idTb, "xxx-xxxxxxx-xx");
        }

        private void voegToeBtn_Click(object sender, EventArgs e)
        {
            if (!TekstVeldenIngevuld(invoerGb))
            {
                MessageBox.Show("Vul alle velden in!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPersoonToegevoegd())
            {
                MessageBox.Show("Persoon toegevoegd aan lijst!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }

        private bool IsPersoonToegevoegd()
        {
            bool leeftijdOk = int.TryParse(leeftijdTb.Text, out int leeftijd) && Persoon.TestLeeftijd(leeftijd);
            bool idOk = Persoon.TestID(idTb.Text);

            if (leeftijdOk && idOk)
            {
                DialogResult dialogResult = MessageBox.Show("Wil u deze persoon toevoegen aan de lijst?", "Informatie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if (dialogResult == DialogResult.OK)
                {
                    Persoon p = new(idTb.Text, naamTb.Text, leeftijd);
                    personen.Add(p);
                    RefreshDataBinding(personenLb, personen, "ID");
                    return true;
                }
                return false;
            }
            VerwerkFouteInvoer(leeftijdOk, idOk);
            return false;
        }

        private void RefreshDataBinding(ListBox listBox, List<Persoon> list, string displayMember)
        {
            listBox.DataSource = null;
            listBox.DataSource = list;
            listBox.DisplayMember = displayMember;
        }

        private void VerwerkFouteInvoer(bool leeftijdOk, bool idOk)
        {
            if (!idOk)
            {
                idTb.BackColor = Color.Red;
            }

            if (!leeftijdOk)
            {
                leeftijdTb.BackColor = Color.Red;
            }
            MessageBox.Show("Foute invoer!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool TekstVeldenIngevuld(GroupBox g)
        {           
            foreach(Control t in g.Controls)
            {
                if (t is TextBox & t.Text == String.Empty) return false;
            }
            return true;
        }

        private void idTb_TextChanged(object sender, EventArgs e)
        {
            idTb.BackColor = SystemColors.Window;
        }

        private void leeftijdTb_TextChanged(object sender, EventArgs e)
        {
            leeftijdTb.BackColor = SystemColors.Window;
        }

    }
}