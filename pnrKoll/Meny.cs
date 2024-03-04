/* Personnummer Verifikation - WindowsFormsApp
 * 
 * En windows forms application som kontrollerar om personnummret är gilltigt och kontrollerar kön på personen,
 * visar personens information beroende på inmatning av Förnamn,Efternamn ,Personnummret och kön i resultatsfält
 * med hjälp av Luhn algoritm
 * 
 * 
 * Begränsningar:
 * Personnummer fält kan ta in bara 10 siffror i format xxxxxxxxxx, icke numerisk tecken
 * Namn fälten tar in bara alfabetiska tecken för att kontrollera
 * Luhn Alogritm används i denna app
 * Fel ger Message Popup fönster som beskriver vad som krävs av användaren
 * Använder styrd app
 * Säkerhets åtgärder behövs för att använda appen på storskal då appen rör om känslig data
 * 
 * 
 * Av: Hassan Hussain
 * Kurs : L0002B
 * Mejl: hashus-9@student.ltu.se
 * 
 * LULEÅ TEKNISKA UNIVERSITET
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pnrKoll
{
    public partial class Meny : Form
    {
        public Meny()
        {
            InitializeComponent();
        }

        private void Meny_Load(object sender, EventArgs e)
        {

        }

        private void avslutaApplikationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private pnrCheck pnrRegi;

        private void registreraPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnrRegi == null || pnrRegi.IsDisposed)
            {
                pnrRegi = new pnrCheck();
                pnrRegi.FormClosed += PnrRegi_FormClosed;
                pnrRegi.Show();
            }
            else
            {
                pnrRegi.BringToFront(); 
            }
        }

        private void PnrRegi_FormClosed(object sender, FormClosedEventArgs e)
        {
            // throw new NotImplementedException();
            //          or
            this.Show();

        }
    }
}
