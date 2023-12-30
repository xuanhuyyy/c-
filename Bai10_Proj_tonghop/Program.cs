namespace Bai10_Proj_tonghop
{
    internal class Program
    {
        static void Minigame()
        {
            int lanthu = 7;
            Console.WriteLine("Game: May tinh ra 1 so bat ky trong doan [0, 500]. Nguoi choi se tien hanh doan so may ra, chi duoc phep doan sai toi da 7 lan.");
            Random rd = new Random();
            int a = rd.Next(501);
            while (true)
            {
                Console.WriteLine("Moi ban nhap so: ");
                int nhapso = int.Parse(Console.ReadLine());
                if (nhapso == a)
                {
                    Console.WriteLine("Chuc mung ban da doan dung");
                    break;
                }
                else
                {
                    lanthu--;
                    Console.WriteLine("Ban da chon sai");
                    if (nhapso < a)
                    {
                        Console.WriteLine("So ban doan < so cua may, ban con {0} lan thu", lanthu);
                    }
                    else
                    {
                        Console.WriteLine("So ban doan > so cua may, ban con {0} lan thu", lanthu);
                    }
                    if (lanthu == 0)
                    {
                        Console.WriteLine("Ban da het luot doan");
                        Console.WriteLine("So cua may la: " + a);
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Minigame();
                Console.WriteLine("Ban co muon choi tiep");
                Console.WriteLine("1. Choi tiep");
                Console.WriteLine("2. Dung lai");
                int chon = int.Parse(Console.ReadLine());
                if(chon == 2)
                {
                    break;
                }else
                {
                    continue;
                }
            }
        }
    }
}
