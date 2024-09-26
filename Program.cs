using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();
Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "45654", modelo: "Modelo 15", imei: "9879879", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.DadosSmartphone();
Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123546", modelo: "Modelo 789", imei: "4698765", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
nokia.DadosSmartphone();
Console.WriteLine("\n");