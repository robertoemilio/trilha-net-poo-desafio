using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//IMPLEMENTADO!!! - Roberto - 25-03-2025

Console.WriteLine("Smartphone Nokia:");
//Smartphone nokia = new Nokia(numero:"123456", modelo: "Modelo1)");
Smartphone nokia = new Nokia(numero: "9656-2430", modelo: "Nokia Ybr", imei: "A3467P", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "8556-8991", modelo:"Iphone 15Pro", imei: "BT5567W", memoria : 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");