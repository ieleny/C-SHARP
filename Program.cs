using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODOSSIMPLES
{
    class METODOSSIMPLES
    {
        static void Main(string[] args)
        {
            //CHAMADA DE METODO
            HelloWordl();

            Console.WriteLine("VEJA OS SEUS DADOS DE FORMA REVERSA");

            Console.Write("ESCREVA SEU NOME: ");
            string PrimeiroNome = Console.ReadLine();

            ReverseString(PrimeiroNome);

            Console.ReadLine();

        }

        //METODOS
        private static void HelloWordl()
        {
            Console.WriteLine("HELLO WORDL");
        }

        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            foreach(char item in messageArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
