using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//implementado
Smartphone iphon = new Iphone("9876-5432", "iPhone 14","001970-01-010000-0", 60);
iphon.Ligar();
iphon.ReceberLigacao();
iphon.InstalarAplicativo("Whatsapp");

Smartphone nokia = new Nokia("1234-5678", "Nokia Tijolão","102970-01-030903-0", 120);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");