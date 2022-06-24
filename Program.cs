using System;
using static Hospital.Hospital;

namespace Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            Doutor dKevin = new Doutor("Kevin", Doutor.Spec.cardio);
            Doutor dGabriel = new Doutor("Gabriel", Doutor.Spec.ortho);
            Adimin aGuilherme = new Adimin("Guilherme");
            Paciente pMarcos = new Paciente("Marcos", 30, dKevin);
            pMarcos.number = "0689643431";
            dKevin.number = "0681950430";

            Console.WriteLine("Wellcome to the O'Donnells Hospital");

            int i = 0;

            while (true)
            {
                i++;
                Console.WriteLine($" --- Scene { i } --- ");
                Console.WriteLine("Who are you?");
                string yourName = Console.ReadLine();

                Pessoa p1;

                if (yourName == dKevin.name)
                    p1 = dKevin;
                else if (yourName == dGabriel.name)
                    p1 = dGabriel;
                else if (yourName == aGuilherme.name)
                    p1 = aGuilherme;
                else if (yourName == pMarcos.name)
                    p1 = pMarcos;
                else
                {
                    Console.WriteLine("NOT FOUND");
                    continue;
                }

                Console.WriteLine("Who you want to contact?");
                string contact = Console.ReadLine();

                IPessoa p2;

                if (contact == dKevin.name)
                    p2 = dKevin;
                else if (contact == dGabriel.name)
                    p2 = dGabriel;
                else if (contact == aGuilherme.name)
                    p2 = aGuilherme;
                else if (contact == pMarcos.name)
                    p2 = pMarcos;
                else
                {
                    Console.WriteLine("NOT FOUND");
                    continue;
                }
                Console.WriteLine(p2.returnNumber(p1));
            }
        }

    }
}
