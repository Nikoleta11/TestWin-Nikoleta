using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin_Nikoleta
{
    public partial class cmbsferaNaRabota : Form
    {
        public cmbsferaNaRabota()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string ime=" ";
            string Prezime=" ";
            string Familiq = " ";
            int egn=0;
            string pol = "";
            string sfera="";
            MessageBox.Show($"Вие въведохте{ime} {Prezime}{Familiq}  с ЕГН{egn} {pol} ,   заетост: {sfera}");
        }

        private void cmbsferaNaRabota_Load(object sender, EventArgs e)
        {

        }
    }
}
