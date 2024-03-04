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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pnrKoll
{
    public class Person
    {
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    private string personnummer;

    public Person(string fname, string lname, string personnummer)
    {
        SetFirstname (fname);
        SetLastname (lname);
        SetPersonnummer(personnummer);
    }

    public string Personnummer
    {
        get { return personnummer; }
        set { SetPersonnummer(value); }
    }

    private void SetFirstname(string value)
    {
        if (value.All(char.IsLetter))
        {
            Firstname = value;  
        }

        else
        {
            MessageBox.Show("Ogiltig inmatning för Förnamn. Endast alfabetiska tecken är tilllåtna." ,nameof(value));
        }
    }

    private void SetLastname(string value)
    {
        if (value.All(char.IsLetter))
        {
            Lastname = value;
        }
        else
        {
            MessageBox.Show("Ogiltig inmatning för Efternamn. Endast alfabetiska tecken är tilllåtna." , nameof(value));
        }
    }

    private void SetPersonnummer(string input)
    {
        //pureinput är den inmatning som är inom vår egenskaper sparas för att arbeta vidare på
        string pureInput = new string(input.Where(char.IsDigit).ToArray());

            if (pureInput.Length == 10 && pureInput.All(char.IsDigit) )
        {
            personnummer = pureInput;
        }
        else
        {
            MessageBox.Show("Ogiltig inmatning för Personnummer. Endast 10 siffror är tilllåtna." , nameof(input));
        }
    }

    public bool CheckPersonnummer()
    {
        //21Algoritm
        string pnrWithoutChecksum = new string(personnummer.Where(char.IsDigit).Take(9).ToArray());

        int sum = 0;
        int multiplier = 2;

        for (int i = pnrWithoutChecksum.Length -1; i >= 0 ; i--)
        {
            int digit = int.Parse(pnrWithoutChecksum[i].ToString());

            int prod = digit * multiplier;

            sum += prod % 10 + prod / 10;

            multiplier = (multiplier == 2) ? 1 : 2;
        }

        int checksum = (sum % 10 == 0 ) ? 0 : 10 - (sum % 10);

        return checksum == int.Parse(personnummer[personnummer.Length - 1].ToString());
    }

    public string checkGender()
    {
        int genderDigit = int.Parse(personnummer[personnummer.Length - 2].ToString());
        return (genderDigit % 2 == 0) ? "Kvinna" : "Man";
    }
    }
}
