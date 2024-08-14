
//Liste Tanımlası yapıldı
List<string> guest = new List<string>();

//Listeye elemean girişleri yapıldı
guest.Add("Bülent Ersoy");
guest.Add("Ajda Pekkan");
guest.Add("Ebru Gündeş");
guest.Add("Hadise");
guest.Add("Hande Yener");
guest.Add("Tarkan");
guest.Add("Funda Arar");
guest.Add("Demet Akalın");

//For Dögüsü ile listedeki elemanlar ekrana yazdırıldı
for(int i  = 0; i < guest.Count; i++)
{
    Console.WriteLine($"{i + 1}-){guest[i]}");
}

