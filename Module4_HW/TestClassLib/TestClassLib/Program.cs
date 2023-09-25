internal class Program
{
    private static void Main(string[] args)
    {
        /*8. Создать массив (не менее 5 элементов) объектов созданного класса*/
        Fridge.DAL.Fridge[] fridges = new Fridge.DAL.Fridge[5];

        
        for (int i = 0; i < fridges.Length; i++)
        {
            Fridge.DAL.Fridge fridge = new Fridge.DAL.Fridge($"Холодильник {i + 1}", 2.0, 500, DateTime.Now.AddYears(1));
            fridges[i] = fridge;
            fridge.PrintInfo();


        }

    }
}