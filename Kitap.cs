class Kitap
{
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
    }
    public virtual void Add()
    {
        Console.WriteLine("Yeni kitap eklendi!");
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