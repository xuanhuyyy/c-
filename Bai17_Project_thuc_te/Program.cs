namespace Bai17_Project_thuc_te
{
    internal class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static void Taotumoi()
        {
            Console.WriteLine("Nhap tu moi TA vao tu dien: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("Tu {0} da co trong tu dien", ta);
            }
            else
            {
                Console.WriteLine("Moi ban nhap vao nghia TV: ");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
                Console.WriteLine("Them thanh cong");
            }
        }
        static void Suatu()
        {
            Console.WriteLine("Nhap vao TA de sua nghia: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Khong tim thay {0} de sua", ta);
            }
            else
            {
                Console.WriteLine("Moi ban nhap lai nghia tieng viet: ");
                string tv = Console.ReadLine();
                dic[ta] = tv;
            }
        }
        static void Tracuu()
        {
            Console.WriteLine("Nhap tu TA: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
            {
                Console.WriteLine("Nghia cua {0} la: {1}", ta, dic[ta]);
            }
        }
        static void Xoatu()
        {
            Console.WriteLine("Nhap tu TA muon xoa: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Khong ton tai");
            }
            else
            {
                dic.Remove(ta);
                Console.WriteLine("Da xoa {0} khoi danh sach", ta);
            }
        }
        static void hienthi()
        {
            foreach (KeyValuePair<string, string> ht in dic)
            {
                Console.WriteLine("TA: {0}; TV: {1}", ht.Key, ht.Value);
            }
        }
        static void Nangcao()
        {
            Console.WriteLine("Dang cap nhat");
        }
        static void menu()
        {
            Console.WriteLine("1. Nhap tu moi vao tu dien\n" +
                "2. Sua tu trong tu dien\n" +
                "3. Cho tra cuu tu dien: Nhap TA de tra ra TV\n" +
                "4. Xoa tu trong tu dien\n" +
                "5. Nang cao: Thay doi cau truc du lieu de lam bo sung tra cuu tu dong nghia\n" +
                "6. Hien thi tu dien\n" +
                "7. Thoat chuong trinh\n" +
                "Moi ban nhap lua chon: ");
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Taotumoi();
                    break;
                case 2:
                    Suatu();
                    break;
                case 3:
                    Tracuu();
                    break;
                case 4:
                    Xoatu();
                    break;
                case 5: Nangcao(); break;
                case 6: hienthi(); break;
                case 7: break;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                Console.WriteLine("Ban co muon nhap tiep?\n" +
                    "1. Tiep tuc\n" +
                    "2. Thoat");
                int k = int.Parse(Console.ReadLine());
                if (k == 2)
                {
                    break;
                }
            }
        }
    }
}
