using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAni1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNume1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar!=46 && e.KeyChar!=8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }   

        private void btnRez_Click(object sender, EventArgs e)
        {
            int aniC1;
            int aniC2;

            Int32.TryParse(txtAni1.Text, out aniC1);
            Int32.TryParse(txtAni2.Text, out aniC2);

            if(txtAni1.Text=="" || txtAni2.Text=="" || txtNume1.Text=="" || txtNume2.Text == "")
            {
                MessageBox.Show("Scrie in toate casutele!");
            }
            else
            {
                if(aniC1>aniC2)
                {
                    MessageBox.Show(txtNume1.Text + " are cu " + (aniC1 - aniC2) + " mai multi ani.");
                }

                if (aniC2 > aniC1)
                {
                    MessageBox.Show(txtNume2.Text + " are cu " + (aniC2 - aniC1) + " mai multi ani.");
                }
                if(aniC2==aniC1)
                {
                    MessageBox.Show("Cei doi au varsta egala.");
                }
            }
        }

        private void btnCerinta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programul va calcula diferența de vârstă x și va afișa pe ecran <<Primul copil este mai mare cu x ani>> dacă primul copil are cea mai mare vârstă, <<Al doilea copil este mai mare cu x ani>> dacă al doilea copil este cel mai în vârstă sau <<Copiii au varste egale>> dacă x=0.");
        }
    }
}
