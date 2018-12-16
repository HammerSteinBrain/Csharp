using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("São José dos Campos");
            cidades.Add("Caçapava");
            cidades.Add("Taubate");
            cidades.Add("Jacarei");
            cidades.Add("Mogi das Cruzes");

            //Console.WriteLine(BuscarPrimeiroForEach(cidades,"Caçapava"));

            //BuscarPrimeiroComLINQ(cidades, "S").ForEach(x => Console.WriteLine(x));

            //BuscarPrimeiroComLINQLambda(cidades, "S").ForEach(x => Console.WriteLine(x));

            Console.WriteLine(TesteLinq(cidades, "Caçapava"));


            Console.ReadKey();
        }



        public static List<string> BuscarPrimeiroComLINQLambda(List<String> lista, string cidade_busca)
        {
            return lista.Where(x => x.Contains(cidade_busca)).ToList();

            //return lista.First(x => x.Equals(cidade_busca));

            //var teste = lista.Where(p => p.ToLower().Equals(cidade_busca.ToLower()));

            //return teste;

        }




        public static List<string> BuscarPrimeiroComLINQ(List<String> lista, string cidade_busca)
        {
            //return (from item in lista where item.Equals(cidade_busca) select item).First();
            return (from item in lista where item.Contains(cidade_busca) select item).ToList();
        }





        public static string BuscarPrimeiroForEach(List<String> lista, string cidade_busca)
        {

            foreach (string item in lista)
            {
                if (item.Equals(cidade_busca))
                {
                    return item;
                }
            }
            return null;
        }


        public static string TesteLinq(List<String> lista, string cidade_busca)
        {
            return (from item in lista where item.Equals(cidade_busca) select item).First();
            //return (from item in lista where item.Contains(cidade_busca) select item).ToList();
        }
    }
}
