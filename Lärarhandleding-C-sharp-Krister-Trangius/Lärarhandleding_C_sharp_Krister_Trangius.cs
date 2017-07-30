namespace Lärarhandleding_C_sharp_Krister_Trangius {
    class Lärarhandleding_C_sharp_Krister_Trangius {
        static void Main(string[] args) {
            // kap. 6
            // System.Console.WriteLine("Hello World");

            // kap. 7
            // 7.1.2
            //System.Console.Write("Ge ett tal: ");
            //double tal1 = System.Convert.ToDouble(System.Console.ReadLine());
            //System.Console.Write("Ge ett tal till: ");
            //double tal2 = System.Convert.ToDouble(System.Console.ReadLine());

            //System.Console.WriteLine("Summan är " + (tal1 + tal2));

            // 7.1.3
            //System.Console.Write("Ge ett tal: ");
            //decimal tal1 = System.Convert.ToDecimal(System.Console.ReadLine());
            //System.Console.Write("Ge ett tal till: ");
            //decimal tal2 = System.Convert.ToDecimal(System.Console.ReadLine());
            //System.Console.Write("Ge ett tredje tal: ");
            //decimal tal3 = System.Convert.ToDecimal(System.Console.ReadLine());

            //decimal medelvärde = (tal1 + tal2+ tal3)/3;
            //System.Console.WriteLine("Medelvärdet är " + System.Math.Round(medelvärde, 2));

            // 7.1.4
            //System.Console.Write("Ge ett decimaltal: ");
            //double decimaltal = System.Convert.ToDouble(System.Console.ReadLine());
            //int heltal = System.Convert.ToInt32(decimaltal);
            //System.Console.WriteLine("Decimaltalet " + decimaltal + " avrundas till " + heltal);

            // 7.1.6
            //System.Console.Write("Ge ett decimaltal: ");
            //double decimaltal = System.Convert.ToDouble(System.Console.ReadLine());
            //double avrundat = System.Math.Round(decimaltal, 2);
            //System.Console.WriteLine("Decimaltalet " + decimaltal + " avrundas till " + avrundat);

            // 7.1.7 - Unicode chars
            //char tecken = (char)79;
            //System.Console.WriteLine("Tecken = " + tecken);

            // System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            //string ideogram = "\u00d6\u00f6";
            //System.Console.WriteLine("Ideogram = " + ideogram);

            //System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            //System.String utf16String = "hej" + ideogram;
            //System.Console.WriteLine("UTF16: " + utf16String);

            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string projectDir = dir + @"\..\..\";
            System.IO.StreamReader reader = new System.IO.StreamReader(projectDir + "latin-1.txt", System.Text.Encoding.GetEncoding("iso-8859-1"));
            System.Console.OutputEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");

            string line;
            while ((line = reader.ReadLine()) != null) {
                System.Console.WriteLine(line);
            }

        }
    }
}
