namespace Esempietti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complesso c;

            c = Complesso.Parse("5+3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("5-3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("5");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("-3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("+5");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("-5");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("-5-3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("-5+3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("+5");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("+5-3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("+5+3i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("-i");
            Console.WriteLine($"{c.R} {c.I}");
            c = Complesso.Parse("+i");
            Console.WriteLine($"{c.R} {c.I}");

            return;

            Console.WriteLine("Inserisci il lato (un numero positivo)");
            float lato;
            
            while (!float.TryParse(Console.ReadLine(), out lato) || lato <= 0)
                Console.WriteLine("Il lato non è corretto");

            Console.WriteLine($"L'area del quadrato è {Quadrato.CalcolaArea(lato)}");

            Quadrato q = new Quadrato();
            q.Lato = lato;

            Quadrato q1 = new Quadrato();
            q1.Lato = lato * 2;

            Console.WriteLine($"L'area del quadrato q è {q.CalcolaArea()}");
            Console.WriteLine($"L'area del quadrato q1 è {q1.CalcolaArea()}");


            Rettangolo r = new Rettangolo();
            r.Lato1 = float.Parse(Console.ReadLine());
            r.Lato2 = float.Parse(Console.ReadLine());

            if (r.IsQuadrato())
                Console.WriteLine("Il rettangolo in realtà è un quadrato");
            else
                Console.WriteLine("CIAO");

        }


    }
}
