namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Inserir elemento na lista: Add, Insert
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            //Tamanho da lista: Count
            Console.WriteLine("List Count: " + list.Count);

            /*Encontrar primeiro ou último elementos da
            lista que satisfaça um predicado:*/
            list.Find, list.FindLast
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("first 'A': " + s1);

            /*• Encontrar primeira ou última posição de elemento da
             lista que satisfaça um predicado:
             list.FindIndex, list.FindLastIndex*/
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Fist Position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");

            foreach(string name in list2)
            {
                Console.WriteLine(name);
            }

            /*Remover elementos da lista: Remove, 
            RemoveAll, RemoveAt, RemoveRange */
            list.Remove("Alex");
            Console.WriteLine("------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            list.RemoveAt(3);
            Console.WriteLine("------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
