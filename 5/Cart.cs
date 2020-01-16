using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Chaining
{
    public class Cart
    {
        Dictionary<int, double> toFile = new Dictionary<int, double>();
        Dictionary<int, double> isFile = new Dictionary<int, double>();
        public StringBuilder doc = new StringBuilder();
        public double sum = 0;
        public void addItem(int item_id, double price, int quantity)
        {
            isFile.Add(item_id, quantity);
            toFile.Add(item_id, price);
            doc.AppendLine("ID:"+item_id+" ,Price:"+price+" ,Quantity:"+quantity);
        }
        public void removeItem(int item_id)
        {
            isFile.Remove(item_id);
            toFile.Remove(item_id);
            doc.AppendLine("ID Remove: " + item_id);
        }
        public void totalPrice()
        {
            foreach(var d in isFile.Values)
            {
                foreach(var x in toFile.Values)
                {
                    double sum = (x * d);
                    doc.AppendLine("Total Harga: " + sum);
                    Console.WriteLine(sum); 
                }
            }
        }
        public void addDiscount(int discount)
        {
            int bil = (discount/100);
            double harga = sum*bil;
            doc.AppendLine("Discount: " + discount);
            doc.AppendLine("Harga Dibayar: "+harga);
            Console.WriteLine(harga);
        }
        public void totalItems()
        {
            int count = isFile.Count();
            doc.AppendLine("Total Barang: " + count);
            Console.WriteLine(count);
            doc.AppendLine("Total item: "+count);
        }
        public void showAll()
        {
            foreach(var d in toFile.Values)
            {
                foreach(var x in isFile.Values)
                {
                    Console.WriteLine(d +" = "+ x);
                    doc.AppendLine("ShowAll: " + d +" = "+ x);
                }
            }
        }
        public void totalQuantity()
        {
            int result = isFile.Values.Sum(list => isFile.Count);
            Console.WriteLine(result);
            doc.AppendLine("Total Quantity: "+result);
        }

        public void checkout(string path)
        {
            File.AppendAllText(path+"checkout.txt", doc.ToString());
            doc.Clear();
        }


    }
}
