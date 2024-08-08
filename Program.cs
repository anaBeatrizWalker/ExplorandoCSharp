using System.Globalization;
using ExplorandoCSharp.Models;

#region Classes e suas propriedades
Person p = new Person(name:"Ana", surname:"Walker");
// p.IntroduceYourself();

Person p2 = new Person(name: "Gustavo", surname: "Santos");

Course englishCourse = new Course();
englishCourse.Name = "Basic English Course";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p);
englishCourse.AddStudent(p2);
englishCourse.GetStudents();
Console.WriteLine($"Current students quantity: {englishCourse.StudentsQuantity()}");

englishCourse.RemoveStudent(p2);
englishCourse.GetStudents();
Console.WriteLine($"Current students quantity: {englishCourse.StudentsQuantity()}");
#endregion

#region Formatação de valores

//Formatação para tipo moeda
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal monetaryValue = 82.40M;
Console.WriteLine($"{monetaryValue:C}"); //formatação pela região padrão
Console.WriteLine(monetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //alterando a região para a formatação
Console.WriteLine(monetaryValue.ToString("N9")); //formatação decimal com 9 casas decimais

//Formatação para porcentagens
double percentage = .3421;
Console.WriteLine(percentage.ToString("P"));

//Formatação com separadores
int number = 123456;
Console.WriteLine(number.ToString("##-##-##"));

//Formatação para datas
DateTime date = DateTime.Now;
Console.WriteLine(date.ToString("dd/MM/yyyy"));
Console.WriteLine(date.ToString("dddd")); //dia da semana
Console.WriteLine(date.ToShortTimeString()); //somente a hora

//Convertendo datas
DateTime convertedDate = DateTime.Parse("31/12/2024");
Console.WriteLine(convertedDate);

string stringDate = "2024-13-31 23:59";
bool conversionHasSuccess = DateTime.TryParseExact(stringDate, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AllowLeadingWhite, out DateTime parsedDate);

if(conversionHasSuccess){
    Console.WriteLine(parsedDate);
} else {
    Console.WriteLine("Data inválida");
}

#endregion