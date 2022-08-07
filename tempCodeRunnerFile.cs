using System;
using System.Collections.Generic;
using System.Linq;

namespace tudien
{
    class Program
    {
        static Dictionary<string, string> tudien;
        static void Main(string[] args)
        {
            int choice;
            tudien=new Dictionary<string, string>();
            do{
                Console.WriteLine("_________________Menu________________");
                Console.WriteLine("1. Nhap tu                          |");
                Console.WriteLine("2. Chinh sua tu                     |");
                Console.WriteLine("3. Tra cuu tu                       |");
                Console.WriteLine("4. Xoa tu                           |");
                Console.WriteLine("5. Thoat                            |");
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Nhap lua chon cua ban tu 1 den 5: ");
                choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    ThemTu();
                    break;
                    case 2:
                    if(tudien.Count == 0)
                    {
                        Console.WriteLine("khong co tu nao trong tu dien");
                        continue;
                    }
                    else{
                        ThayThe();
                    }
                    break;
                    case 3:
                    if(tudien.Count == 0)
                    {
                        Console.WriteLine("khong co tu nao trong tu dien");
                        continue;
                    }
                    else{
                        TinTu();
                    }
                    break;
                    case 4:
                    if(tudien.Count == 0)
                    {
                        Console.WriteLine("khong co tu nao trong tu dien");
                        continue;
                    }
                    else{
                        XoaTu();
                    }
                    break;
                    case 5:
                    Console.WriteLine("Ban thoat roi");
                    break;
                }
            }while(choice!=5);
        }
        static void ThemTu()
        {
            int  luachon;
            string Tkey, TValue;
            do{
                alo:
                Console.Write("Nhap tu: ");
                Tkey=Console.ReadLine();
                foreach ( KeyValuePair<string, string> item in tudien)
                {
                    if(tudien.ContainsKey(Tkey))
                    {
                        Console.WriteLine("Tu nay da co trong tu dien");
                        goto alo;
                    }

                }
                Console.Write("Nhap nghia: ");
                TValue=Console.ReadLine();
                tudien.Add(Tkey, TValue);
                Console.WriteLine("Nhan phim 1 de tiep tuc nhap them tu, Nhan phim 2 de quay lai menu: ");
                luachon=int.Parse(Console.ReadLine());
                Console.ReadLine();
            }while(luachon!=2);
        }
        static void ThayThe()
        {
            string tuCanSua, tuThay, tuMoi;
            Sualai:
            Console.Write("Nhap tu muon thay the: ");
            string thayThe =Console.ReadLine();
            for(int i=0; i<tudien.Count; i++)
            {
                if(tudien.ContainsKey(thayThe))
                {
                    tuCanSua=tudien.Keys.ElementAt(i);
                    tuThay=tudien.Values.ElementAt(i);
                    Console.WriteLine("Nhap tu thay the: ");
                    tuMoi=Console.ReadLine();
                    tudien.Remove(tuCanSua);
                    tudien.Add(tuMoi, tuThay);
                    Console.WriteLine("tu da duoc sua.");
                    int chomo;
                    do{
                        Console.WriteLine("1. de tiep tuc, 2. de quay ve menu");
                        chomo=int.Parse(Console.ReadLine());
                        if(chomo==1)
                        {
                            goto Sualai;
                        }
                    }while(chomo!=2);
                    break;
                    
                }
                else{
                    Console.WriteLine("khong co tu ny trong tu dien");
                }
                int chom;
                do{
                    Console.WriteLine("1. de tiep tuc, 2. de quay lai menu");
                    chom=int.Parse(Console.ReadLine());
                    if(chom==1)
                    {
                        goto Sualai;
                    }
                }while(chom!=2);
            }
            Console.WriteLine();
        }
        static void TinTu()
        {
            int chom;
            do{
                Console.Write("Nhap tu can tim: ");
                string timTu=Console.ReadLine();
                foreach(KeyValuePair<string, string> item in tudien)
                {
                    if(timTu==item.Key)
                    {
                        Console.WriteLine($"Tu {timTu} co nghia la: {item.Value}");

                    }
                }
                Console.WriteLine("1. de tiep tuc, 2. de quay lai menu");
                chom=Convert.ToInt32(Console.ReadLine());
            }while(chom!=2);
            Console.WriteLine();
        }
        static void XoaTu()
        {
            Xoa:
            Console.Write("Nhap tu can xoa: ");
            string xoaTu =Console.ReadLine();
            foreach(KeyValuePair<string, string> item in tudien)
            {
                if(tudien.ContainsKey(xoaTu))
                {
                    tudien.Remove(xoaTu);
                    Console.WriteLine($"da xoa tu {xoaTu}");
                    int chomama;
                    do{
                        Console.WriteLine("1. de tiep tuc, 2. de quay lai menu");
                        chomama=int.Parse(Console.ReadLine());
                        if(chomama==1)
                        {
                            goto Xoa;
                        }
                    }while(chomama!=2);
                    Console.WriteLine();

                }
                else
                {
                    int chomame;
                    do{
                        Console.WriteLine($"{xoaTu} khong co trong tu dien");
                        Console.WriteLine("1. de tiep tuc, 2. de quay lai menu");
                        chomame=int.Parse(Console.ReadLine());
                    }while(chomame!=2);
                }
            }
            Console.WriteLine();

        }
    }
}
