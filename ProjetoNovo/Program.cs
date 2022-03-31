using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Cliente c = new Cliente();
            ClienteVip cv = new ClienteVip();
            c.cadastrarNome();
            c.exibirNome();
            cv.codigoVip = 100;
            cv.cadastrarNome();
            cv.exibirDados();

            Console.ReadKey();
        }
    }
}
