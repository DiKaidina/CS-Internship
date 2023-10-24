using MyClassLib.WorldOfTanks;

internal class Program
{
    static void BattleResults(Tank[] team1, Tank[] team2)
    {

        if (team1.Length != team2.Length)
        {
            Console.WriteLine("Разное количество танков в командах. Сражение невозможно.");
            return;
        }

        for (int i = 0; i < team1.Length; i++)
        {
            Tank tank1 = team1[i];
            Tank tank2 = team2[i];

            try
            {
                bool result = tank1 * tank2;
                if (result)
                {
                    Console.WriteLine($"{tank1.GetTankName()} победил {tank2.GetTankName()}");
                }
                else
                {
                    Console.WriteLine($"{tank2.GetTankName()} победил {tank1.GetTankName()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
    private static void Main(string[] args)
    {
        Tank[] pantera = new Tank[5];
        Tank[] t34 = new Tank[5];

        for (int i = 0; i < 5; i++)
        {
            pantera[i] = new Tank("Pantera");
            t34[i] = new Tank("Т-34");
        }

        // Вывод параметров всех танков "Pantera"
        Console.WriteLine("Параметры танков Pantera:");
        foreach (Tank tank in pantera)
        {
            Console.WriteLine(tank.GetTankParameters());
        }

        // Вывод параметров всех танков "Т-34"
        Console.WriteLine("\nПараметры танков Т-34:");
        foreach (Tank tank in t34)
        {
            Console.WriteLine(tank.GetTankParameters());
        }

        BattleResults(t34, pantera);
    }
}