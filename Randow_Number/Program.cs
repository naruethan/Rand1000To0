// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Random Number from 1000 until the random number equal to zero");
Console.WriteLine("Each time the random number should less than the previous number.");
Console.WriteLine("");



int last_num = 0;
int currrent_rand = 0;
string show_result;
Random rnd = new Random();
List<int> list = new List<int>();

rand(currrent_rand, last_num ,list);
show_result = Showrand(list);
Console.WriteLine("result random : " + show_result);


static void rand(int currrent_rand, int last_num, List<int> list) { 

do {
        Random rnd = new Random();
        currrent_rand = rnd.Next(0, 1000);

    if(last_num == 0)
    {
        last_num = currrent_rand;
        list.Add(last_num);


    }

    if (currrent_rand < last_num)
    {

        last_num = currrent_rand;
        list.Add(last_num);
        //Console.WriteLine("last_num  : {0}", last_num);
    }


   } while (last_num != 0);

}

static string Showrand(List<int> list)
{
    int[] terms = list.ToArray();
    string result = "";

    foreach (int term in terms)
    {

        if (term == 0)
        {
            result = result + term.ToString();

        }
        else
        {
            result = result + term.ToString() + ",";

        }

    }
    return result;

}



Console.ReadLine();