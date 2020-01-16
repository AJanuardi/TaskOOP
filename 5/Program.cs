using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            cart.addItem(1, 30000, 3);
            cart.addItem(2, 10000, 1);
            cart.addItem(3, 50000, 2);
            cart.addItem(4, 400, 6);
            cart.removeItem(2);
            cart.totalItems();
            cart.totalQuantity();
            cart.totalPrice();
            cart.addDiscount(50);
            cart.showAll();
            cart.checkout("D:/");
            
        }
    }
}
