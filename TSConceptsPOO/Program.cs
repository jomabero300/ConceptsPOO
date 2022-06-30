using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
using TSConceptsPOO;
Console.WriteLine("POO Concepts");
Console.WriteLine("============");
// try
// {
//     Console.WriteLine(new Date(2024, 2, 29));
//     Console.WriteLine(new Date(2022, 6, 9));
//     Console.WriteLine(new Date(2022, 11, 15));
// }
// catch (System.Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

Employee employee1=new SalaryEmployee(){
Id=100,
FirstName="Jose Manuel",
LastName="Bello Romero",
BirthDate=new Date(1972,10,25),
HiringDate=new Date(2022,1,17),
IsActive=true,
Salary=1500000.15M,
};

Employee employee2=new CommissionEmployee(){
    Id=2020,
    FirstName="Patricia",
    LastName="Gutierrez",
    BirthDate=new Date(1995,5,23),
    HiringDate=new Date(2022,2,5),
    IsActive=true,
    CommissionPercentaje=0.03F,
    Sales=320000000M,
};

Employee employee3=new HourlyEmployee()
{
    Id=3030,
    FirstName="Gonzalo",
    LastName="Cardona",
    BirthDate=new Date(1985,6,18),
    HiringDate=new Date(2022,5,23),
    HourValue=12356.56M,
    Hours=123.5F,
    IsActive=true,
};

Employee employee4=new BaseCommissionEmployee(){
    Id=4040,
    FirstName="Jazmin",
    LastName="Ramirez",
    BirthDate=new Date(1985,5,23),
    HiringDate=new Date(2022,5,6),
    IsActive=true,
    Base=860678.45M,
    Sales=58000000M,
    CommissionPercentaje=0.015F,
};

// Console.WriteLine(employee1);
// Console.WriteLine(employee2);
// Console.WriteLine(employee3);
// Console.WriteLine(employee4);

ICollection<Employee> employees=new List<Employee>()
{
    employee1,employee2,employee3,employee4
};

decimal payroll=0;

foreach (var item in employees)
{
    Console.WriteLine(item);
    payroll += item.GetValueToPay();
}

Console.WriteLine("                                  ===============");
Console.WriteLine($"Total                          {$"{payroll:C2}",18}");

Invoice invoice1=new Invoice()
{
    Description="iPhone 13",
    Id=1,
    Prince=5300000M,
    Quantity=6
};
Invoice invoice2=new Invoice()
{
    Description="Posta premiun",
    Id=2,
    Prince=32000M,
    Quantity=17.5F
};


Console.WriteLine(invoice1);
Console.WriteLine(invoice2);