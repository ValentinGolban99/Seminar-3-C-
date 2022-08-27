//17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату по оси oX: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси oY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("I Четверть");
else if (x < 0 && y > 0) Console.WriteLine("II Четверть");
else if (x < 0 && y < 0) Console.WriteLine("III Четверть");
else Console.WriteLine("IV Четверть");
// Команда "else if " - позволяет сделать одну большую проверку
// Строка с 10 по 13 это одна проверка




