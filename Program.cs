using DesafioPOO.Models;

System.Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone("123", "IPhone 14", "123456789", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Iphone("321", "Nokia ABC1", "987654321", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");