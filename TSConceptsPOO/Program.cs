// See https://aka.ms/new-console-template for more information
using TSConceptsPOO;
Console.WriteLine("POO Concepts");
Console.WriteLine("============");
try
{
    Console.WriteLine(new Date(2024,2,29));
    Console.WriteLine(new Date(2022,6,9));
    Console.WriteLine(new Date(2022,11,15));    
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}
