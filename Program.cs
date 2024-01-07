using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone nokia:");
Nokia nokia = new Nokia("12345", "1", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone("4582", "3", "4444444", 524);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");
