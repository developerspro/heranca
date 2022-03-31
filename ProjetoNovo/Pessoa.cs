using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo
{
    class Pessoa
    {
        private string nome;
        public string telefone;
        public string contato;
        public  Endereco endereco;

        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine().ToUpper();
            
        }

        public void exibirNome()
        {
            Console.WriteLine("Nome:"+nome);
        }
    }
}
