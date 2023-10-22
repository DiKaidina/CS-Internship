
internal class Program
{
    public static void Main(string[] args)
    {
        //Task_1
        
        HW_8.SquaredArray array = new HW_8.SquaredArray(5);

        array[0] = 2; 
        array[1] = 3; 

        int value1 = array[0]; // Получаем текущее значение элемента с индексом 0 (4)
        int value2 = array[1];

        Console.WriteLine($"Значение элемента 0: {value1}"); 
        Console.WriteLine($"Значение элемента 1: {value2}");

        //Task_2
        HW_8.Communalka calculator = new HW_8.Communalka(0.1, 20, 15, 0.05, 10);

        
        double area = 100;          
        int numberOfPeople= 4;  
        bool isWinterSeason = true; 

        // Выводим таблицу с платежами
        Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"Отопление\t{calculator["Heating", area, numberOfPeople, isWinterSeason]}\t{0}\t{calculator["Heating", area, numberOfPeople, isWinterSeason]}");
        Console.WriteLine($"Вода\t{calculator["Water", area, numberOfPeople, isWinterSeason]}\t{0}\t{calculator["Water", area, numberOfPeople, isWinterSeason]}");
        Console.WriteLine($"Газ\t{calculator["Gas", area, numberOfPeople, isWinterSeason]}\t{0}\t{calculator["Gas", area, numberOfPeople, isWinterSeason]}");
        Console.WriteLine($"Ремонт\t{calculator["Repair", area, numberOfPeople, isWinterSeason]}\t{0}\t{calculator["Repair", area, numberOfPeople, isWinterSeason]}");
    }
}