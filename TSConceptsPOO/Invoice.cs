using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSConceptsPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public float Quantity { get; set; }
        public decimal Prince { get; set; }
        public decimal GetValueToPay()
        {
            return Prince * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{Id} - {Description}"+
                $"\n\tQuantity.......: {$"{Quantity:N2}", 18}"+
                $"\n\tPrince.........: {$"{Prince:C2}", 18}"+
                $"\n\tValue..........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}