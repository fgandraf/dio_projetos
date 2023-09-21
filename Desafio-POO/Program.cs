using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9999-8888", modelo: "Lumia", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "9888-7777", modelo: "10 Plus", imei: "987654321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");