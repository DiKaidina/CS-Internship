namespace Fridge.DAL
{
    public partial class Fridge  //Для создания частичного класса (пункт 9).все определения этого класса должны быть частичными.
    {
        /*5.Создать не менее двух статических полей (различных типов), представляющих общие характеристики объектов данного класса*/
     
        public static int TotalFridgesCount = 0; // Общее количество созданных холодильников
        public static double AverageFridgeCost = 0.0; // Средняя стоимость холодильников


        /*2.Пять закрытых полей различных типов*/

        private string FridgeName { get; set; }
        private double FridgeVersion { get; set;}

        private int TotalCost { get; set; }

        private bool IsSold { get; set; }

        private DateTime Guarantee_Term { get; set; }



        /*6. Добавить в класс перегруженный конструктор + (пункт 7) статический констурктор*/
        // Конструктор по умолчанию


        // Статический конструктор
        static Fridge()
        {
            //для инициализации статических полей
            TotalFridgesCount = 0;
            AverageFridgeCost = 0.0;
        }

        //конструктор по умолчанию
        public Fridge()
        {
            FridgeName = "Неизвестно";
            FridgeVersion = 1.0;
            TotalCost = 0;
            IsSold = false;
            Guarantee_Term = DateTime.MinValue;

            // Увеличиваем общее количество созданных холодильников при создании нового объекта
            TotalFridgesCount++;

            // Обновляем среднюю стоимость холодильников при создании нового объекта
            AverageFridgeCost = (AverageFridgeCost * (TotalFridgesCount - 1) + TotalCost) / TotalFridgesCount;
        }

        // Перегруженный конструктор с пользовательскими аргументами
        public Fridge(string name, double version, int cost, DateTime guaranteeTerm)
        {
            this.FridgeName = name;
            this.FridgeVersion = version;
            this.TotalCost = cost;
            this.IsSold = false;
            this.Guarantee_Term = guaranteeTerm;

            // Увеличиваем общее количество созданных холодильников при создании нового объекта
            TotalFridgesCount++;

            // Обновляем среднюю стоимость холодильников при создании нового объекта
            AverageFridgeCost = (AverageFridgeCost * (TotalFridgesCount - 1) + TotalCost) / TotalFridgesCount;
        }

        /*3.Создать не менее трех методов управления классом и методы доступа к его закрытым полям*/

        // Методы доступа к полям
        public string GetFridgeName()
        {
            return FridgeName;
        }

        public double GetFridgeVersion()
        {
            return FridgeVersion;
        }


        public DateTime GetGuaranteeTerm()
        {
            return Guarantee_Term;
        }

        //методы кправления классом
        public void ApplyDiscount(int discountAmount)
        {
            if (!IsSold)
            {
                // Проверяем, что холодильник не продан
                // Применяем скидку к TotalCost
                TotalCost -= discountAmount;
            }
        }

        // Метод для продажи холодильника
        public void SellFridge()
        {
            IsSold = true;
        }

        // Метод для получения информации о холодильнике
        public string GetFridgeInfo()
        {
            string info = $"Имя: {FridgeName}\nВерсия: {FridgeVersion}\nСтоимость: {TotalCost} тг\nПродан: {(IsSold ? "Да" : "Нет")}\nГарантия до: {Guarantee_Term.ToShortDateString()}";
            return info;
        }



        /*4.Создать метод, в который передаются аргументы по ссылке*/

        public void ModifyFridge(ref string name, ref double version)
        {
            // Изменяем значения переданных аргументов по ссылке
            name = "Новое имя холодильника";
            version = 2.0;
        }


        
    }
}