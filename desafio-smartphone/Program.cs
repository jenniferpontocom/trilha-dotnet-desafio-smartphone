using DesafioPOO.Models;

// FEITO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("NOKIA:");
Smartphone nokia = new Nokia(numero: "99112233", modelo: "Flip 19-89", imei: "01122023", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("IPHONE:");
Smartphone iphone = new Iphone(numero: "99887766", modelo: "8 Pro Max", imei: "10012024", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");