namespace name1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number= new List<int>();
            Console.WriteLine("p-print numbers");
            Console.WriteLine("A-Add numbers");
            Console.WriteLine("M-display mean of numbers");
            Console.WriteLine("S-display thes mallest numbers");
            Console.WriteLine("l-display the largest numbers");
            Console.WriteLine("F-find anubers in the list");
            Console.WriteLine("C-clear the list");
            Console.WriteLine("C-clear the list");
            Console.WriteLine("Q-quit");
            Console.WriteLine("T-الرقم تكرر");
            Console.WriteLine("G-0~1");
           
            char fox= Convert.ToChar(Console.ReadLine());
            switch(fox)
            {
                case 'p':
                    if(number.Count==0)
                    {
                        Console.WriteLine(" []-the list is empty");
                    }
                    else
                    {
                        int d = 0;
                        while (d<number.Count) ;
                        Console.WriteLine(number[d]);
                        d++;
                        
                       
            


                    }
                    break;
                case 'A':
                    Console.WriteLine("enter anumber");
                    int ttt = Convert.ToInt32(Console.ReadLine());
                    number.Add(ttt);
                    Console.WriteLine(ttt + " added");





                    break;
                case 'S':
                    int small = number[0];
                    int i = 1;
                        while (i < number.Count) ;
                    if (number[i] < small) ;
                    i++;
                    Console.WriteLine("small:" + small);
                    break;
                case 'L':
                    int big = number[0];
                    int e = 1;
                    while (e > number.Count) ;
                    if (number[e] > big)
                        e--;
                    Console.WriteLine("big:" + big);

                    break;
                case 'f':
                    Console.WriteLine("enter nember to list;");
                    int tar=int.Parse(Console.ReadLine());
                    bool find= false;
                    int h = 0;
                    while (h < number.Count) ;
                    if (number[h]==tar)
                    {
                        Console.WriteLine("fond");
                    }
                    else
                    {
                        Console.WriteLine(" notfond");
                    }
                    h++;
                    break;
                case 'c':
                    number.Clear();
                    Console.WriteLine("list cleared");
                    break;
                case 'Q':
                    Environment.Exit(0);

                    break;
                case 'T':
                    Console.WriteLine("enter numder");
                    int n = int.Parse(Console.ReadLine());
                    bool naw = false;
                    for (int d = 0; d < number.Count; d++)
                        if (number[d] == n)
                        {
                            naw = true;
                            Console.WriteLine("الرقم ده موجود");
                        }
                    else
                        {
                            Console.WriteLine("الرقم ده مش موجود");
                        }
                    break;
                case 'G':

                    Console.Write("Enter number: ");
                    int p = int.Parse(Console.ReadLine());

                    int found = 0;
                    int s = 0;

                    while (s < number.Count)
                    {
                        if (number[s] == p)
                        {
                            found = 1;
                        }
                        s++;
                    }

                    Console.WriteLine(found);

                    if (found == 1)
                    {
                        Console.WriteLine("الرقم ده متكرر!");
                    }
                    else
                    {
                        number.Add(p);
                    }
                    break;
                default:
                    break;



























            }

            


        }
    }
}
