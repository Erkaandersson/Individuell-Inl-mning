using System.ComponentModel;
using System.Diagnostics;

namespace Filhantering_Inlamning
{
    internal class Program
    {
        //funktion som har en return type för generisklist string, och som tar en parameter av string array.
        // Samt tar en char letter som parameter som används för att skapa en lista av namn på den bokstaven.
        public static List<string> ToAList<T>(string[] listOfNames, char letter)
        {
            //Skapar lista som jag konverterar arrayen till.
            List<string> nameList = listOfNames.ToList();

            //Skapar en ny lista där jag kan spara namn som börjar på a.
            List<string> aList = new List<string>();

            //Foreach loop för att loopa igenom namnen i listan och en if sats för att kolla första bokstaven.
            foreach (string name in nameList)
            {
                
                if (name.ToString().ToUpper()[0] == letter) 
                {
                    aList.Add(name);
                    Console.WriteLine(name);
                }
            }
            //Returnerar den nya listan med namn som börjar på bokstaven som är inskickad med funktionen. 
            return aList;
         
        }
        //Skapar en metod för att skapa en ny mapp på min hårddisk, som tar min aList som parameter.
        public static void CreateFolder(List<string> aList, char nameOfList)
        {
            
            //skapar en variabel path där mappen ska skapas. Mappen skapas under den bokstav som skickas in med funktionen i main.

            string path = @$"C:\Webbutvecklare\{nameOfList}";

            //Kollar så att det inte finns en path med det namnet redan. Annars skapas den.

            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //Skapar en textfil som sparas i mappen som skapades.
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, $"{nameOfList}List.txt")))
            {
                foreach (string name in aList)
                    outputFile.WriteLine(name);
            }
        }

        //Kallar metoder ifrån main med en lista som parameter. 

        static void Main(string[] args)
        {
            //skapar en char input för att kunna köra funktionen lättare. Ändra bokstaven under input - 
            // - för att kolla namn i listan och skapa mapp och fil. 
            char input = 'a';
            string[] names = { "Alfa", "Beta","Charlie","Delta" };
            CreateFolder(ToAList<string>(names, input),input);
        }
    }
}
