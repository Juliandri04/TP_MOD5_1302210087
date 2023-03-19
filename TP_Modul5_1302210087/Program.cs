using TP_Modul5_1302210087;

string nama = Console.ReadLine();
HaloGeneric haloGeneric = new HaloGeneric();
haloGeneric.SapaUser(nama);

DataGeneric<string> dataGeneric = new DataGeneric<string>("1302210087");
dataGeneric.PrintData();
