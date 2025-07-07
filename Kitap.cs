class Kitap
{
    private int Id { get; set; }
    private string KitapAdi { get; set; }
    private string Yazar { get; set; }
    private string YayinEvi { get; set; }
    private int SayfaSayisi { get; set; }
    private bool Durum { get; set; }
    private void Kitap(int _Id, string _KitapAdi, string _Yazar, string _YayinEvi, int _SayfaSayisi)
    {
        Id = _Id;
        KitapAdi = _KitapAdi;
        Yazar = _Yazar;
        YayinEvi = _YayinEvi;
        SayfaSayisi = _SayfaSayisi;
        Durum = true;
     }

}

class Roman : Kitap
{
    
}