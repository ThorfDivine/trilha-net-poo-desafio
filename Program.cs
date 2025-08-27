using DesafioPOO.Models;
Nokia nokia = new Nokia("11 98739-9087", "A4", "asj234", 1024);
Console.WriteLine(nokia);
nokia.ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Iphone Iphone = new iphone("11 89563-0245", "iphone 15 pro max", "app122", 2048);
Console.WriteLine(iphone);
iphone.ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("facebook");
