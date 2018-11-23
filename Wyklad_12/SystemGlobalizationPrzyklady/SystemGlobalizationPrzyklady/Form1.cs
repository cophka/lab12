using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Dodanie przestrzenie nazw do obsługi Globalizacji i Wątków
using System.Globalization;
using System.Threading;

namespace SystemGlobalizationPrzyklady
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKultury_Click(object sender, EventArgs e)
        {
            //Utworzenie zmiennej tablicowej klasy CultureInfo przechowującej dane o kulturach dostepnych w systemie
            CultureInfo[] kultury = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            //Dla każdej zmiennej w tablicy wyświetl informacje o kulturze
            foreach (CultureInfo zebrane_kultury in kultury)
            {
                MessageBox.Show(zebrane_kultury.Name.ToString());
            }
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            //Utworzenie zmiennej klasy RegionInfo przechowującej informacje o danej kulturze
            RegionInfo regionFrancja = new RegionInfo("FR");
            //Wyświetlenie szczegółowych informacji o danej kulturze
            MessageBox.Show("Name: " + regionFrancja.Name);
            MessageBox.Show("Display name: " + regionFrancja.DisplayName);
            MessageBox.Show("Symbol (pol. waluta): " + regionFrancja.CurrencySymbol);
        }

        private void btnModyfikacjaFormatuDaty_Click(object sender, EventArgs e)
        {
            //Utworzenie zmiennej klasy DateTimeFormatInfo umożliwiającej formatowanie daty i ustawienie jej na format brytyjski
            DateTimeFormatInfo dateFormat1 = new CultureInfo("en-GB", false).DateTimeFormat;
            //Utworzenie zmiennej klasy DateTimeFormatInfo umożliwiającej formatowanie daty i pobranie jej wartości dla bieżącego wątku
            DateTimeFormatInfo dateFormat2 = Thread.CurrentThread.CurrentCulture.DateTimeFormat;

            //Wyświetlenie zawartości powyższych zmiennych
            MessageBox.Show("dateFormat1 : "+ dateFormat1.ShortDatePattern);
            MessageBox.Show("dateFormat2 : " + dateFormat2.ShortDatePattern);

            //Modyfikacja skrótowych oznaczeń miesięcy w zmiennej datefFormat1
            dateFormat1.AbbreviatedMonthNames = new string[] { "Jn", "Fb", "Marzec OK", "Ap", "My", "Jn", "Jy", "Au", "Se", "Oc", "Nv", "De", "" };

            //Utworzenie ciągu znakowego currentDate przechowującą sformatowaną wartość zmiennej dateFormat1
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy",dateFormat1);

            //Wyświetlenie zawartości zmiennej currentDate
            MessageBox.Show(currentDate);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Utworzenie zmiennej numberFormat do której wpisujemy informacje o formatowaniu liczb pobranych z bieżącego wątku 
            NumberFormatInfo numberFormat = Thread.CurrentThread.CurrentCulture.NumberFormat;

            //Wyświetlenie informacji o separatorze liczb dzisiętnych i separatorze grupy liczb pobranych z bieżącego wątku 
            MessageBox.Show("Separator liczb dziesiętnych: " + numberFormat.NumberDecimalSeparator);
            MessageBox.Show("Separator grup liczb: " + numberFormat.NumberGroupSeparator);
        }

        private void btnCiagiZnakow_Click(object sender, EventArgs e)
        {
            string string1 = "strings test";
            string string2 = "Strings test";

            //Utworzenie zmiennej stringComp klasy CompareInfo umożliwiającej porównywanie ciągów znakowych zgodnie z zasadami obowiązującymi w danej kulturze
            CompareInfo stringComp = Thread.CurrentThread.CurrentCulture.CompareInfo;
            //Wyświetlenie wyników porównania bez opcji lub z opcją ingnorowania dużych liter (Porównanie 2)
            MessageBox.Show("Porównanie 1: " + stringComp.Compare(string1, string2, CompareOptions.None));
            MessageBox.Show("Porównanie 2: " + stringComp.Compare(string1, string2, CompareOptions.IgnoreCase));

            string1 = "strings test";
            string2 = "string's test";

            //Wyświetlenie wyników porównania z opcją ignorowania symboli
            MessageBox.Show("Porównanie 3: " + stringComp.Compare(string1, string2, CompareOptions.IgnoreSymbols));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
