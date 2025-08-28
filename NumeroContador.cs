public class NumeroContador
{
    public void ContarSincrono()
    {
        for (int i = 1; i <= 30; i++)
        {
            Console.WriteLine($"Número {i}");
            Thread.Sleep(1000);
        }
    }
    
    public async Task ContarAsincrono()
    {
        for (int i = 1; i <= 30; i++)
        {
            Console.WriteLine($"Número {i}");
            await Task.Delay(1000);
        }
    }
}