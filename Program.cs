

namespace sqlgyak
{
    internal class Program
    {
        List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
        static void Main(string[] args)
        {

            StreamReader sr= new StreamReader("Kolcsonzesek.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var mezok = sr.ReadLine().Split(';');
                Kolcsonzes beolvas= new Kolcsonzes(mezok[0], mezok[1][0], int.Parse(mezok[2]), int.Parse(mezok[3]), int.Parse(mezok[4]), int.Parse(mezok[5]));
            }
            sr.Close();

            List<Kolcsonzes> masik = File.ReadLines("kolcsonzes.txt").Skip(1).Select(x=>new Kolcsonzes(x)).ToList();


        }
    }
}