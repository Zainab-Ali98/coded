// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Enter number");

//int x = Convert.ToInt32(Console.ReadLine());

//if (x % 2 ==0)
//{
//  Console.WriteLine("even");
//}
//else
//{
//   Console.WriteLine("odd");
//}

Console.WriteLine("Enter your name");
string y = Console.ReadLine();

Console.WriteLine("Enter Gender");
string z = Console.ReadLine();

Console.WriteLine("Active or nonActive");
string h = Console.ReadLine();

if (h == "Active" && z == "femele") 
{
    Console.WriteLine("welcome ms "+y);
}
else if(h=="Active" && z =="male")
{
    Console.WriteLine("welcome mr ahmad"+y);
} else
{
    Console.WriteLine("non");
}