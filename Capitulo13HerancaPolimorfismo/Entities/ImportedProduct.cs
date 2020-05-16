using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Capitulo13HerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            CustomsFee = customsFree;
        }       
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}
