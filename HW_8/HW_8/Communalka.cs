using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    public class Communalka
    {
        private double heating; // Тариф на отопление за 1 м2
        private double water;   // Тариф на воду за 1 человека
        private double gas;     // Тариф на газ за 1 человека
        private double repair;  // Тариф на текущий ремонт за 1 м2
        private double discount;

        public Communalka(double heating, double water, double gas, double repair, double discount)
        {
            this.heating = heating;
            this.water = water;
            this.gas = gas;
            this.repair = repair;
            this.discount = discount;
        }

        //индексатор
        public double this[string paymentType, double area, int numberOfpeople, bool isWinterSeason]
        {
            get
            {
                double baseRate = 0;
                double discount = 0;

                switch (paymentType)
                {
                    case "Heating":
                        baseRate = area * heating;
                        break;
                    case "Water":
                        baseRate = numberOfpeople * water;
                        break;
                    case "Gas":
                        baseRate = numberOfpeople * gas;
                        break;
                    case "Repair":
                        baseRate = area * repair;
                        break;
                   
                }

                if (isWinterSeason)
                {
                    baseRate *= 1.2; // Повышение тарифа зимой на 20%
                }

                double total = baseRate;

                if (discount > 0)
                {
                    discount = (baseRate * discount) / 100;
                    total = baseRate - discount;
                }

                return total;
            }
        }
    }
}
