using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(525, 0);
            } catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(ex.Message);                
            }

            Console.ReadLine();
        }
    }
}
