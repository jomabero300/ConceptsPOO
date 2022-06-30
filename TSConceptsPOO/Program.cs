﻿// See https://aka.ms/new-console-template for more information
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

Console.WriteLine(employee1);
Console.WriteLine(employee2);