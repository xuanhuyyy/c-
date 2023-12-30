namespace Bai15_List_trong_C_
{
    internal class Program
    {
        static void HocList()
        {
            List<string> list = new List<string>();
            list.Add("B");
            list.Add("A");
            list.Add("C");
            list.Insert(1, "D");
            list.RemoveAt(0);
            list.Sort();
            foreach (var s in  list)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Nhap chu muon tim: ");
            string k = Console.ReadLine();
            int kq = list.IndexOf(k.ToUpper());
            if(kq < 0)
            {
                Console.WriteLine("Khong tim thay {0} trong ds", k);
            }
            else
            {
                Console.WriteLine("{0} o vi tri {1}", k, kq);
            }
        }
        static void Main(string[] args)
        {
            HocList();
        }
    }
}
