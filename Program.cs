namespace KutuphaneYonetimSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap newb = new Roman(1, "Mavi", "Ahmet", "KK", 165);
            newb.Add();
            Roman newb1 = new Roman(2, "Kirmizi", "Mehmet", "HH", 56);
            newb.Add();
        }
    }
}
