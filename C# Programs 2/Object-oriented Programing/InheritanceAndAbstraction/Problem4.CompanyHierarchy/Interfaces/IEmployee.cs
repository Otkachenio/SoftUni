namespace Problem4.CompanyHierarchy
{
    interface IEmployee : IPerson
    {
        Departament Departament { get; }
        decimal Salary { get; }
    }
}