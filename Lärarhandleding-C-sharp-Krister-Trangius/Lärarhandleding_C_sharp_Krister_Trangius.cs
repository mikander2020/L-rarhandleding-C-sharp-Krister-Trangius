namespace Lärarhandleding_C_sharp_Krister_Trangius {
    class Lärarhandleding_C_sharp_Krister_Trangius {
        static void Main(string[] args) {
            // kap. 6
            // System.Console.WriteLine("Hello World");

            // kap. 7
            //System.Console.Write("Ge ett tal: ");
            //double tal1 = System.Convert.ToDouble(System.Console.ReadLine());
            //System.Console.Write("Ge ett tal till: ");
            //double tal2 = System.Convert.ToDouble(System.Console.ReadLine());

            //System.Console.WriteLine("Summan är " + (tal1 + tal2));

            System.Console.Write("Ge ett tal: ");
            decimal tal1 = System.Convert.ToDecimal(System.Console.ReadLine());
            System.Console.Write("Ge ett tal till: ");
            decimal tal2 = System.Convert.ToDecimal(System.Console.ReadLine());
            System.Console.Write("Ge ett tredje tal: ");
            decimal tal3 = System.Convert.ToDecimal(System.Console.ReadLine());

            decimal medelvärde = (tal1 + tal2+ tal3)/3;
            System.Console.WriteLine("Medelvärdet är " + System.Math.Round(medelvärde, 2));

        }
    }
}
