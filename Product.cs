using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__MultiWindow
{
    [Serializable]
    public class Product    {
       
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} " +
                $"Price: {Price} UAH " +
                $"Countity: {Quantity} " +
                $"Country: {Country} " +
                $"Discount: {Discount} ";
        }

    }
}
