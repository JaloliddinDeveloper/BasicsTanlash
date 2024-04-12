////1.Vaqt kalkulyatori:
//Console.Write("Vaqtni kiriting (min) da: ");
//int time=int.Parse(Console.ReadLine());
//int hour = time / 60;
//int minuts = time % 60;
//Console.WriteLine($"Berilgan {time} minut = {hour} soat: {minuts} minut ekan");

////2.Yosh toifasini aniqlash:
//Console.Write("Enter your age: ");
//int age = int.Parse(Console.ReadLine());
//if (age >= 0 && age <= 12)
//    Console.WriteLine("Bola");

//else if (age >= 13 && age <= 19)
//    Console.WriteLine("O'smir");

//else if (age >= 20 && age <= 59)
//    Console.WriteLine("Kattalar");

//else
//    Console.WriteLine("Yoshi ulug'");

////3.O'rtacha ballni hisoblash:
//Console.Write("1-fandan olingan baxo (0-100): ");
//int birinchiFan = int.Parse(Console.ReadLine());
//Console.Write("2-fandan olingan baxo (0-100): ");
//int ikkinchiFan = int.Parse(Console.ReadLine());
//Console.Write("3-fandan olingan baxo (0-100): ");
//int uchinchiFan = int.Parse(Console.ReadLine());
//double overalBall = (birinchiFan + ikkinchiFan + uchinchiFan) /3;
//string result = (overalBall > 0 && overalBall < 40)
//    ?"Qoniqarsiz" :(overalBall >= 40 && overalBall <= 59)
//    ? "Qoniqarli" : (overalBall >= 60 && overalBall <= 79) 
//    ? "Yaxshi" : (overalBall >= 80 && overalBall <= 100) 
//    ? "Alo" : "0";
//Console.WriteLine(result);

////4."Raqamni toping" o'yini:
//Console.WriteLine("Kampyuter Bir son o'yladi: ");
//var random = new Random();
//int a = random.Next(0, 1100);
//Console.WriteLine("Kampyuter o'ylagan sonni toping?");
//int k = 0;
//while (a != k)
//{
//    k = int.Parse(Console.ReadLine());
//    if (k < a) Console.WriteLine($"Kampyuter o'ylagan son {k} sonidan katta");
//    else if (k > a) Console.WriteLine($"Kampyuter o'ylagan son {k} sonidan kichik");
//    else Console.WriteLine("Barakalla siz topdingiz!!!");
//}


