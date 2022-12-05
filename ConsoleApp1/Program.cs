using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using ConsoleApp1;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
            List<Pessoa> irmaos = dados.GetNames();
            DateTime d = DateTime.Today;
            int i = 0;
            int qtHor = 2;
            int qtDup = 2;
            int numDiasAGerar = 4;

            while (i++ < numDiasAGerar)
            {
                List<string> GenerateOfDay = new List<string>();
                Console.Write("------- ");
                Console.Write((d.AddDays(7 * i)).ToString("dd/MM/yyyy"));
                Console.WriteLine(" -------");
                Console.WriteLine("");
                for (int h = 0; h < qtHor; h++)
                {
                    Console.Write("--- ");
                    Console.Write("Horario " + (h + 1));
                    Console.WriteLine(" ---");
                    Console.WriteLine("");
                    for (int j = 0; j < qtDup; j++)
                    {
                        var c = 0;
                        Pessoa prevPerson = new Pessoa();
                        while (c++ < qtDup)
                        {
                            Pessoa brother = GeneratePessoa(irmaos);
                            string brotherName = brother.Name;
                            if (brotherName == null) break;

                            if (!string.IsNullOrEmpty(prevPerson.Name))
                            {
                                while (!CheckRules(prevPerson, brother) || GenerateOfDay.Any(x => x == brother.Name))
                                {
                                    brother = GeneratePessoa(irmaos);
                                    brotherName = brother.Name;
                                }
                            }

                            GenerateOfDay.Add(brotherName);
                            prevPerson = brother;

                            Console.WriteLine(brotherName);
                        }

                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        static Pessoa GeneratePessoa(List<Pessoa> irmaos)
        {
            return irmaos.Count() == 0 ? null : irmaos[new Random().Next(irmaos.Count())];
        }

        static bool CheckRules(Pessoa prevPerson, Pessoa curPerson) //false gera outro nome novamente.
        {
            if (string.IsNullOrEmpty(prevPerson.Name)) return false;

            // colocar apenas do mesmo sexo ou se forem casados
            if (curPerson.IsMarried && prevPerson.Name != curPerson.Spouse) return false;
            else if (prevPerson.Sex != curPerson.Sex) return false;

            // Não colocar o irmão para sair consigo próprio
            if (prevPerson.Name == curPerson.Name) return false;

            return true;
        }

    }
}
