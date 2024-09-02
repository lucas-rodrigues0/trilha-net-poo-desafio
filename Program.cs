using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "22335641", modelo: "NokiaN1", imei: "11111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.SobreSmartphone();


Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "44221365", modelo: "IphoneS2", imei: "2222222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.SobreSmartphone();
