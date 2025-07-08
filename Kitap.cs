abstract class Kitap
{
    private static int KitapList = 0;
    private int Id { get; set; }
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

// Interface

interface IKiralama
{
    void KitapKirala();
    void KitapIadeEt();
}