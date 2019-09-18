using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Menu
    {

        public string Nome { get; set; }
        public int Senha { get; set; }
        public int Id { get; set; }

        public Menu(string nome, int fone, int id)
        {
            Nome = nome;
            Senha = Senha;
            Id = id;
        }

        public void alteraNome(string novoNome)
        {
            Nome = novoNome;
        }
    

       
            
        

            
    }
}
