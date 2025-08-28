var palavras = new PalavraContador();
var numeros = new NumeroContador();

Console.WriteLine("Contagem Síncrona:");
palavras.ContarSincrono();
numeros.ContarSincrono();

Console.WriteLine("Contagem Assíncrona:");
var tarefaPalavras = palavras.ContarAssincrono();
var tarefaNumeros = numeros.ContarAsincrono();

await Task.WhenAll(tarefaPalavras, tarefaNumeros);
Console.WriteLine("Contagem Assíncrona Concluída.\nRecibido palavras e números!");

