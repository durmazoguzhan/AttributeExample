using AttributeInveonOrnek.console;


Ogrenci ogr = new Ogrenci();
ogr.adi = "Oğuzhan";
ogr.soyadi = "Durmaz";
ogr.bolum = "Yazılım";


if (!ZorunlulukKontrolu.Dogrula(ogr))
{
    Console.WriteLine("Öğrenci bilgileri girilmesi zorunludur.");
}
else
{
    Console.WriteLine("Form başarılı");
}