using System;

namespace Methoden_120123_AufgabeS24
{
    class Program
    {
        static void Main(string[] args)
        {


            bool bolWeiter = true;
            double[] dblArray = new double[1];

            //Array Länge für alle Cases
            int i = 0;

            while (bolWeiter)
            {

                Console.WriteLine("Was wollen Sie machen?");
                Console.WriteLine("1 - Zahl in Array speichern");
                Console.WriteLine("2 - Eingabe Überschreiben");
                Console.WriteLine("3 - Wert löschen");
                Console.WriteLine("4 - Wert verdoppeln");
                Console.WriteLine("5 - Wert halbieren");
                Console.WriteLine("9 - Programm beenden");
                string strAuswahl = Console.ReadLine();
                Console.Clear();

                switch (strAuswahl)
                {
                    case "1": //Zahl hinzufügen

                        Console.WriteLine("Bitte geben Sie die zu speichernde Zahl ein");
                        //Bei neuem Wert (Also wenn die vorhandene Länge nicht ausreicht) resizen
                        if (i == dblArray.Length)
                        {
                            Array.Resize(ref dblArray, dblArray.Length + 1);
                        }

                        dblArray[i] = mthArraySpeichern(Console.ReadLine());
                        i++;

                        break;

                    case "2": //Eingabe überschreiben

                        Console.WriteLine("Die aktuellen Werte: ");
                        foreach (double dblArrayWert in dblArray)
                        {
                            Console.WriteLine(dblArrayWert);
                        }

                        Console.WriteLine("Bitte wählen Sie von 1 beginnend das zu überschreibende Datenfeld");

                        dblArray = mthArrayUeberschreiben(dblArray, Console.ReadLine());
                        i--;
                        break;

                    case "3": //Wert entfernen

                        Console.WriteLine("Die aktuellen Werte: ");
                        foreach (double dblArrayWert in dblArray)
                        {
                            Console.WriteLine(dblArrayWert);
                        }

                        Console.WriteLine("Bitte wählen Sie von 1 beginnend das zu löschende Datenfeld");

                        dblArray = mthArrayAusschneiden(dblArray, Console.ReadLine());
                        i--;
                        break;

                    case "4": //Wert verdoppeln

                        Console.WriteLine("Die aktuellen Werte: ");
                        foreach (double dblArrayWert in dblArray)
                        {
                            Console.WriteLine(dblArrayWert);
                        }

                        Console.WriteLine("Bitte wählen Sie von 1 beginnend den zu verdoppelnden Wert");

                        dblArray = mthArrayWertVerdoppeln(dblArray, Console.ReadLine());
                        
                        break;

                    case "5": //Wert halbieren

                        Console.WriteLine("Die aktuellen Werte: ");
                        foreach (double dblArrayWert in dblArray)
                        {
                            Console.WriteLine(dblArrayWert);
                        }

                        Console.WriteLine("Bitte wählen Sie von 1 beginnend den zu halbierenden Wert");

                        dblArray = mthArrayWertHalbieren(dblArray, Console.ReadLine());

                        break;

                    case "9":

                        bolWeiter = false;
                        

                        break;
                }
            }
        }

        public static double mthArraySpeichern(string strEingabe)
        {
            double dblEingabe = 0;
            double.TryParse(strEingabe, out dblEingabe);
            return dblEingabe;
        }

        public static double[] mthArrayUeberschreiben(double[] tempArray, string strIndex)
        {
            int intIndex = 0;
            int.TryParse(strIndex, out intIndex);

            Console.WriteLine("Bitte den neuen Wert angeben");
            string strNeuerWert = Console.ReadLine();

            double dblNeuerWert = 0;
            double.TryParse(strNeuerWert, out dblNeuerWert);

            tempArray[intIndex - 1] = dblNeuerWert;

            Console.WriteLine("Der geänderte Array ist: ");
            foreach (double dblWert in tempArray)
            {
                Console.WriteLine(dblWert);
            }
            return tempArray;
        }

        public static double[] mthArrayWertVerdoppeln(double[] tempArray, string strIndex)
        {
            int intIndex = 0;
            int.TryParse(strIndex, out intIndex);

            tempArray[intIndex - 1] = tempArray[intIndex - 1] * 2;

            Console.WriteLine("Der geänderte Array ist: ");
            foreach (double dblWert in tempArray)
            {
                Console.WriteLine(dblWert);
            }
            return tempArray;
        }

        public static double[] mthArrayWertHalbieren(double[] tempArray, string strIndex)
        {
            int intIndex = 0;
            int.TryParse(strIndex, out intIndex);

            tempArray[intIndex - 1] = tempArray[intIndex - 1] / 2;

            Console.WriteLine("Der geänderte Array ist: ");
            foreach (double dblWert in tempArray)
            {
                Console.WriteLine(dblWert);
            }
            return tempArray;
        }
        public static double[] mthArrayAusschneiden(double[] tempArray, string strIndex)
        {
            int intIndex = 0;
            int.TryParse(strIndex, out intIndex);
            intIndex--;
            
            for(int i =intIndex; i<tempArray.Length - 1; i++)
            {
                tempArray[i] = tempArray[i + 1];
            }
            Array.Resize(ref tempArray, tempArray.Length - 1);


            Console.WriteLine("Der geänderte Array ist: ");
            foreach (double dblWert in tempArray)
            {
                Console.WriteLine(dblWert);
            }
            return tempArray;
        }
        
    }
}
