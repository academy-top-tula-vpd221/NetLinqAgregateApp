using NetLinqAgregateApp;

List<Employee> employees = new()
{
    new(){ Name = "Jim", Age = 34, Salary = 34000 },
    new(){ Name = "Sam", Age = 21, Salary = 45000 },
    new(){ Name = "Bob", Age = 45, Salary = 28000 },
    new(){ Name = "Leo", Age = 32, Salary = 62000 },
    new(){ Name = "Tim", Age = 28, Salary = 41000 },
    new(){ Name = "Joe", Age = 41, Salary = 22000 },
    new(){ Name = "Bill", Age = 35, Salary = 57000 },
};

double res = 0;
foreach (var e in employees)
    res += e.Salary * 0.13;
Console.WriteLine(res);

double result = employees.Aggregate(0, (s, e) => s + (int)(e.Salary * 0.13));
Console.WriteLine(result);

var res30 = employees.Count(e => e.Age > 30);
Console.WriteLine(res30);

var amountAll = employees.Sum(e => e.Salary);
Console.WriteLine(amountAll);

var minAge = employees.Min(e => e.Age);
Console.WriteLine(minAge);

var maxSalary = employees.Max(e => e.Salary);
Console.WriteLine(maxSalary);

var avgAge = employees.Average(e => e.Age);
Console.WriteLine(avgAge);