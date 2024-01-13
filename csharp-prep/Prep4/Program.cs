using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int num = -1;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(num != 0){
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if(num != 0){
                numbers.Add(num);
            }
            
        }


        int total=0;

        foreach(int no in numbers){
            total+=no;
        }
        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int maxValue = numbers[0];
        foreach( int i in numbers){
            if(i > maxValue){
                maxValue = i;
            }
        }

        Console.WriteLine($"The max is: {maxValue}");

        numbers.Sort();
        foreach(int j in numbers){
            Console.WriteLine(j);
        }
    }
}