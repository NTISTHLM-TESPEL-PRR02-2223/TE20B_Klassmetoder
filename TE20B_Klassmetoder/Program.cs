
Enemy e1 = new Enemy();
Enemy e2 = new Enemy();

e1.hp -= 5;

Console.WriteLine($"E1 hp: {e1.hp}");
Console.WriteLine($"E2 hp: {e2.hp}");

e1.Heal();

Console.WriteLine($"E1 hp: {e1.hp}");
Console.WriteLine($"E2 hp: {e2.hp}");

Console.ReadLine();

