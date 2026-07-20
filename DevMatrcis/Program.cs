//innerjoin join
//leftjoin leftouterJoin
//rightJoin rightouterjoin
//fulljoin

using DevMatrcis;

List<Employee> employee = new List<Employee>() 
{ 
    new Employee(){ Id = 1, Name = "John",Age = 36,Gender= Gender.Male, Department_id=1,},
    new Employee(){ Id = 2, Name = "Jane",Age = 30,Gender= Gender.Female, Department_id=2,},
    new Employee(){ Id = 3, Name = "Bob", Age = 33,Gender= Gender.Male,Department_id=1,},
    new Employee(){Id = 4, Name = "Alice", Age = 40, Gender = Gender.Female, Department_id = 6},
    new Employee(){Id = 5, Name = "Tom", Age = 31, Gender = Gender.Male, Department_id = 2},
    new Employee(){Id = 6, Name = "Jerry", Age = 26, Gender = Gender.unknown, Department_id = 3},
    new Employee(){Id = 7, Name = "Mike", Age = 22, Gender = Gender.Male, Department_id = 4},
    new Employee(){Id = 8, Name = "Sara", Age = 29, Gender = Gender.Female, Department_id = 2},
    new Employee(){Id = 9, Name = "David", Age = 25, Gender = Gender.Male, Department_id = 4},
    new Employee(){Id = 10, Name = "Emma", Age = 32, Gender = Gender.Female},
};


List<Departments> departments = new List<Departments>()
{
    new Departments(){ Id = 1, Name = "HR", Location = "New York"},
    new Departments(){ Id = 2, Name = "IT", Location = "San Francisco"},
    new Departments(){ Id = 3, Name = "Finance", Location = "Chicago"},
    new Departments(){ Id = 4, Name = "Marketing", Location = "Los Angeles"},
    new Departments(){ Id = 5, Name = "Sales", Location = "Houston"},
};

//innerjoin
//query syntax
var innerJoin = from emp in employee
                join dept in departments on emp.Department_id equals dept.Id
                select new { emp.Name, emp.Gender,
                  deptname =  dept.Name, dept.Location };

//method syntax
var innerJoinMethod = employee.Join(departments, emp => emp.Department_id, dept => dept.Id,
    (emp, dept) => new {
        emp.Name, emp.Gender,
        deptname = dept.Name,
        dept.Location });



//leftouter join

//foreach (var item in innerJoin)
//{
//    Console.WriteLine($"Name: { item.Name}, Gender: { item.Gender},Department Name: { item.deptname}, Location: { item.Location}");
// }

//leftjoin 
//query syntax
 var leftJoin = from emp in employee
                join dept in departments on emp.Department_id equals dept.Id into empDept
                from dept in empDept.DefaultIfEmpty()
                select new { emp.Name, emp.Gender,
                    deptname = dept != null ? dept.Name : "No Department",
                    Location = dept != null ? dept.Location : "No Location" };
foreach (var item in leftJoin)
{
    Console.WriteLine($"Name: {item.Name}, Gender: {item.Gender},Department Name: {item.deptname}, Location: {item.Location}");
}