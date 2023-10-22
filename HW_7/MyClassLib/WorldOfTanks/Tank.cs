using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private string tankName;
        private int boyecomplect;
        private int bron_level;
        private int manevr_level;
        private static Random random = new Random();

        public Tank(string name)
        {
            tankName = name;
            boyecomplect = random.Next(0, 101); 
            bron_level = random.Next(0, 101); 
            manevr_level = random.Next(0, 101); 
        }

        //Получение текущих значений параметров танка
        public string GetTankParameters()
        {
            return $"Танк {tankName}: Боекомплект: {boyecomplect}, Броня: {bron_level}, Маневренность: {manevr_level}";
        }

        public string GetTankName()
        {
            return tankName;
        }

        public static bool operator *(Tank tank1, Tank tank2)
        {
            int points = 0;

            if (tank1.boyecomplect > tank2.boyecomplect)
            {
                points++;
            }
            if (tank1.bron_level > tank2.bron_level)
            {
                points++;
            }
            if (tank1.manevr_level > tank2.manevr_level)
            {
                points++;
            }

            return  points >= 2;
        }
     






    }
}
