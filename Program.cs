using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo Axx", imei: "748349", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "54321", modelo: "Modelo I4", imei: "99239", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

