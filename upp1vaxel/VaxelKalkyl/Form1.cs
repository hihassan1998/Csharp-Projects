/*
 * Ett Windows Forms Applikation som beräknar hur mycket växel man ska få tillbaka berende på hur mycket pris är och hur mycket man har betalat
 * som visa i kvitto format där antal sedlar och mynt visas
 * 
 * Begränsningar: 
 * Om betalt belopp är mindre än pris , Varning utskriven som indikerar att kontrollera indata
 * Om växeln är noll eller mindre uteskrivs varning 
 * Om input ej är nummer visar pop up meddelande som guidar att använda siffror
 * Om Växel är noll skrivs att det inte finns behöv att betala växel.
 *
 * 
 * 
 * 
 * 
 * 
 * Av : Hassan Hussain
 * Kurs: L0002B
 * LULEÅ TEKNISKA UNIVERSITET
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VaxelKalkyl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPriceKr_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPriceKr.Text, out _))
            {
                txtPriceKr.Clear();
                MessageBox.Show("Ange Siffror!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtMoneyKr_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtMoneyKr.Text, out _))
            {
                txtMoneyKr.Clear();
                MessageBox.Show("Ange Siffror!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPriceKr.Text = "0";
            txtMoneyKr.Text = "0";
            rtbChange.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du är på väg att avsluta appen", "Hej Då!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();   
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal krprice = decimal.Parse((txtPriceKr.Text));
            decimal krpaid = decimal.Parse((txtMoneyKr.Text));

            decimal krChange = krpaid - krprice;
            if (krChange < 0)
            {
                
                rtbChange.AppendText("\n !!! Varning !!!\n");
                rtbChange.AppendText("\n Felaktigt belopp. Ange ett större betalt belopp.");
            }
            else if (krChange == 0){
                rtbChange.AppendText("Ingen växel behövs att betala.");
            
            }

            else
            {
                rtbChange.Text = $"Växel: {krChange:C}\n";
                calcChange(krChange);
            }
        }
        private void calcChange(decimal krChange)
        {
            int[] notes = { 500, 200, 100, 50, 20 };
            int[] coins = { 10, 5, 1 };

            rtbChange.AppendText("\n--------Växel Kvitto---------\n");
            rtbChange.AppendText("Växel i Sedlar och Mynt\n");

            foreach (int denomination in notes)
            {
                int count = (int)(krChange / denomination);
                if (count > 0)
                {
                    rtbChange.AppendText($"{denomination}-kronor (sedel): {count}\n");
                    krChange -= count * denomination;
                }
            }
            foreach (int denomination in coins)
            {
                int count = (int)(krChange / denomination);
                if (count > 0)
                {
                    rtbChange.AppendText($"{denomination}-kronor (mynt): {count}\n");
                    krChange -= count * denomination;
                }
            }
        }
    }
}
