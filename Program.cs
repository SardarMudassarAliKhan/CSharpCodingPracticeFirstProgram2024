using CSharpCodingPracticeFirstProgram;

//Input for taking input from user for Id
Console.WriteLine("Enter Student Id");
int Id=Convert.ToInt32(Console.ReadLine());

// Input for taking the name of student from user
Console.WriteLine("Enter Student Name");
string Name = Console.ReadLine();

// Input for taking the input for RollNo 
Console.WriteLine("Enter Student Name RollNo");
string RollNo = Console.ReadLine();

// Input for taking the input for Gpa 
Console.WriteLine("Enter Student Name Gpa");
double Gpa = Convert.ToDouble(Console.ReadLine());

BasicProgram basicProgram = new BasicProgram(Id, Name, RollNo, Gpa);
basicProgram.DisplayInfo();
