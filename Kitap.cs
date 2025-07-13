// Interface

interface IKiralama
{
    void KitapKirala(int id);
    void KitapIadeEt();
}

abstract class Kitap : IKiralama
{

    private static int KitapList = 0;

    private int Id;
    public int id
    {
        get { return Id; }
        private set;
    }
    private string KitapAdi { get; set; }
    private string Yazar { get; set; }
    private string YayinEvi { get; set; }
    private int SayfaSayisi { get; set; }
    private bool Durum { get; set; }
    public Kitap(int _Id, string _KitapAdi, string _Yazar, string _YayinEvi, int _SayfaSayisi)
    {
        Id = _Id;
        KitapAdi = _KitapAdi;
        Yazar = _Yazar;
        YayinEvi = _YayinEvi;
        SayfaSayisi = _SayfaSayisi;
        Durum = true;
        KitapList++;
    }

    public virtual void KitapKirala(int _Id)
    {
        if (Durum)
        {
            Durum = false;
            Console.WriteLine($"{KitapAdi} kitabý kiralandý.");
        }
        else
        {
            Console.WriteLine($"{KitapAdi} kitabý zaten kiralanmýþ.");
        }
    }
    public void KitapIadeEt()
    {
        Durum = true;
        Console.WriteLine($"{KitapAdi} kitabý iade edildi.");
    }
    public abstract void Add();
    public void KitapListele() {
        Console.WriteLine($"ID: {Id}\nKitap Adi: {KitapAdi}\nYazar: {Yazar}\nYayin Evi: {YayinEvi}\nSayfa Sayisi: {SayfaSayisi}\nDurum: {(Durum ? "Mevcut" : "Kiralanmis")}");
    }
}

class Roman(int _Id, string _KitapAdi, string _Yazar, string _YayinEvi, int _SayfaSayisi) : Kitap(_Id, _KitapAdi, _Yazar, _YayinEvi, _SayfaSayisi)
{
    public override void Add()
    {
        Console.WriteLine("Yeni roman eklendi!");
    }
}

class CocukKitabi(int _Id, string _KitapAdi, string _Yazar, string _YayinEvi, int _SayfaSayisi) : Kitap(_Id, _KitapAdi, _Yazar, _YayinEvi, _SayfaSayisi)
{
    public override void Add()
    {
        Console.WriteLine("Yeni cocuk kitabi eklendi!");
    }
}

class Ansiklopedi(int _Id, string _KitapAdi, string _Yazar, string _YayinEvi, int _SayfaSayisi) : Kitap(_Id, _KitapAdi, _Yazar, _YayinEvi, _SayfaSayisi)
{
        public override void Add()
    {
        Console.WriteLine("Yeni ansiklopedi eklendi!");
    }
 }

