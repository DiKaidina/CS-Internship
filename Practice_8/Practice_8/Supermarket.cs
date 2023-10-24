using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    class Supermarket
    {
        public string[] products;
        public double[] prices;

        public Supermarket()
        {
            //продукты и цены
            products = new string[] { "Хлеб", "Молоко", "Яйца", "Овощи", "Фрукты" };
            prices = new double[] { 2.0, 1.5, 3.0, 5.0, 4.0 };
        }

        //воспользуемся индексаторами
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < products.Length)
                {
                    return prices[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Продукт с таким номером не найден.");
                }
            }
        }

        public double TotalAmount(int[] selectedProductIndexes, bool isDiscountTime)
        {
            double totalAmount = 0;

            foreach (int index in selectedProductIndexes)
            {
                totalAmount += this[index];
            }

            if (isDiscountTime)
            {
                double discount = totalAmount * 0.05; // 5% скидка
                totalAmount -= discount;
            }

            return totalAmount;
        }
    }
    }
