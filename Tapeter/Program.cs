namespace Tapeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv vägghöjd: ");
            float höjd = float.Parse(Console.ReadLine());
            Console.WriteLine("Skriv längd på väggen: ");
            float längd = float.Parse(Console.ReadLine());
            float m2 = höjd * längd;

            Console.WriteLine("Längden på tapetrullen: ");
            float längdTapet = float.Parse(Console.ReadLine());
            Console.WriteLine("Bredden på tapetrullen: ");
            float breddTapet = float.Parse(Console.ReadLine());

            float tapetRulle = m2 * längdTapet;

            float tapetremsa = längdTapet / höjd;
            Console.WriteLine("Remsor från en rulle: " + tapetremsa);
            float antalTapetrullar = längd / tapetremsa;

            Console.WriteLine("Du behöver " + antalTapetrullar + "rullar");
            
        }
    }
}