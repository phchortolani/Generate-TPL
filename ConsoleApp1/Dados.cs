using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Dados
    {
     
        public List<Pessoa> GetNames()
        {
            List<Pessoa> names = new List<Pessoa> {
                new Pessoa("Alex Silva",'H'),
                new Pessoa("Andressa Gomes",'M'),
                new Pessoa("Catia Rodrigues",'M'),
                new Pessoa("Cleide Morais",'M'),
                new Pessoa("Dara Hortolani",'M', "Paulo Henrique"),
                new Pessoa("Edna Morais",'M'),
                new Pessoa("Eliane Lima",'M'),
                new Pessoa("Geronimo Santos",'H',"Vasti"),
                new Pessoa("Hilario Dores",'H'),
                new Pessoa("Irene Nassif",'M'),
                new Pessoa("Janete Silva",'M', "Valdir"),
                new Pessoa("João Lima",'H'),
                new Pessoa("Jucielene Oliveira",'M'),
                new Pessoa("Lice Morgan",'M'),
                new Pessoa("Lucia Viera",'M'),
                new Pessoa("Marcos Bueno",'H'),
                new Pessoa("Marlene Marques",'M', "Marcos Marques"),
                new Pessoa("Michele Morais",'M', "Rogério Morais"),
                new Pessoa("Marcos Marques",'H', "Marlene Marques"),
                new Pessoa("Natanael Santos",'H'),
                new Pessoa("Paulo Henrique",'H', "Dara Hortolani"),
                new Pessoa("Paulo Lima",'H'),
                new Pessoa("Paulo Lopes",'H'),
                new Pessoa("Pedro Barros",'H'),
                new Pessoa("Rogério Morais",'H',"Michele Morais"),
                new Pessoa("Sandro Roberto",'H'),
                new Pessoa("Tarsila Germano",'M'),
                new Pessoa("Vladineia Dores",'M'),
                new Pessoa("Volnei Viera",'H',"Lucia Viera"),
                new Pessoa("Wesley França",'H'),
            };
            return names;
        }
    }
}
