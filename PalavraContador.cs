public class PalavraContador
{
    public void ContarSincrono()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Palavra {i}");
            Thread.Sleep(1000);
        }
    }

    public async Task ContarAssincrono()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Palavra {i}");
            await Task.Delay(1000);
        }
    }
}