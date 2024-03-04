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
    public partial class pnrCheck: Form
    {
        public pnrCheck()
        {
            InitializeComponent();
        }
        private void checkBtn_Click(object sender, EventArgs e)
        {   //kontrollerar om alla fält är ifyllda
            if (string.IsNullOrWhiteSpace(lastnameTxt.Text) || string.IsNullOrWhiteSpace(firstnameTxt.Text) || string.IsNullOrWhiteSpace(pnrTxt.Text) )
            {
                MessageBox.Show("Vänligen fyll i alla fält innan du kontrollerar Personen.", "Ofullständigt Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Skriv ut retultat om kontoll OK
            Person person = new Person( firstnameTxt.Text, lastnameTxt.Text, pnrTxt.Text);   
            
            if (person.CheckPersonnummer())
            {
                resultatBox.Text = $"Förnamn: {person.Firstname}\nEfternamn: {person.Lastname}\nPersonnummer: {person.Personnummer}\nKön: {person.checkGender()}";
            }
            else
            {
                resultatBox.Text = "Ogiltigt personnummer";
            }
        }

        private void clBtn_Click(object sender, EventArgs e)
        {
            //tömmer inmatining fälten
            lastnameTxt.Text = "";
            firstnameTxt.Text = "";
            pnrTxt.Text = "";

        }

        private bool isFirstClick = true;
        private void pnrTxt_Click(object sender, EventArgs e)
        {
            // för att ta bort förslag info i Personnnumemer fält
            if (isFirstClick)
            {
                pnrTxt.Text = string.Empty;
                pnrTxt.SelectionStart = 0;  
                isFirstClick = false;   
            }
        }

        private void pnrTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
