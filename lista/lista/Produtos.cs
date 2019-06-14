using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Produtos
    {
        List<Produto> listaProdutos ;

        public List<Produto> ListaProdutos
        {
            get => listaProdutos; set => listaProdutos = value;
        }

        public Produtos()
        {
            this.ListaProdutos = new List<Produto>();
        }


        public void adicionar(Produto p)
        {
            this.ListaProdutos.Add(p);
        }

        public bool remover(Produto p)
        {
           Produto remove =  this.pesquisar(p);
           if(remove.Codigo < 0)
            {
                return false;
            }
            else
            {
                this.ListaProdutos.Remove(remove);
                return true;
            }

        }

        public Produto pesquisar(Produto p)
        {
            foreach(Produto pesquisado in this.ListaProdutos)
            {
                if(pesquisado.Equals(p))
                {
                    return pesquisado;
                }
            }

            return new Produto();
            
        }

        public double custoTotal()
        {
            double custo = 0;

            foreach(Produto elemento in this.ListaProdutos)
            {
                custo += elemento.custo();
            }
            return custo;
        }
    }
}
