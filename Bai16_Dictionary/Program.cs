namespace Bai16_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Le");
            dic.Add(2, "Xuan");
            dic.Add(3, "Huy");
            Console.WriteLine(dic.ContainsKey(2));
            Console.WriteLine(dic.ContainsValue("Xuan"));
            foreach(KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine("Ma: {0} ; Ten: {1}",kvp.Key,kvp.Value);
            }
            string value = dic[3];
            Console.WriteLine(value);
            List<string> dsgiatri = dic.Values.ToList();
            foreach(string v in dsgiatri)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("List Key tuong tu");
        }
    }
}
