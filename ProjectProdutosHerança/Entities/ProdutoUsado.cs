using System;
using System.Globalization;


namespace ProjectProdutosHerança.Entities
{
    class ProdutoUsado : Produto
    {

        public DateTime Date { get; protected set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string name, double valor, DateTime data): base(name,valor)
        {

            Date = data;

        }

        public override void AddProduto(Produto produto)
        {
            base.AddProduto(produto);
        }

        public override string ToString()
        {
            return Name  +" (used) $ "+Value.ToString("F2", CultureInfo.InvariantCulture) + "(Manufacture date: "+Date.ToString("dd/MM/yyyy")+")"; 
        }
    }
}
