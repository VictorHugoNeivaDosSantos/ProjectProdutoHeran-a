using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ProjectProdutosHerança.Entities
{
    class Produto
    {
        public List<Produto> Lista { get;  protected set; } = new List<Produto>();
        public string Name { get; protected set; }
        public double Value { get; protected set; }

        public Produto()
        {
        }

        public Produto(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public virtual void AddProduto(Produto produto)
        {
            Lista.Add(produto);

        }

        public override string ToString()
        {

            return Name + " $ " + Value.ToString("F2",CultureInfo.InvariantCulture);    
            
        }

        public void List()
        {

            foreach (Produto prod in Lista)
            {

                System.Console.WriteLine(prod);

            }

        }
    }
}
