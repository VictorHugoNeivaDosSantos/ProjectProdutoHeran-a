using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ProjectProdutosHerança.Entities
{
    class ProdutoImportado : Produto
    {

        public double TaxaImport { get; protected set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string name, double value, double taxa) : base(name, value)
        {

            TaxaImport = taxa;
        }

        public override void AddProduto(Produto produto)
        {
            base.AddProduto(produto);
        }
        public override string ToString()
        {
            return Name + " $ " + (Value + TaxaImport).ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee : " + TaxaImport + ")";
        }

    }
}
