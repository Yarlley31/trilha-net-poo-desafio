using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone meuIphone = new Iphone("123456789", "iPhone 14", "ABCDEFGHIJKLMNOP", 128);
meuIphone.Ligar();
meuIphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Nokia meuNokia = new("9876543", "Nokia Tijolão", "ASFASDFWERQAS", 64);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Jogo da Cobrinha");