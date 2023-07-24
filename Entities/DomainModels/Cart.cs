using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.DomainModels
{
    public class Cart:IDomaninModel
    {
        public Cart()
        {
            CartLines=new List<CartLine>();
        }
        public IList<CartLine> CartLines { get; set; }

       
    }
}
