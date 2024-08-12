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
// englishCourse.GetStudents();
// Console.WriteLine($"Current students quantity: {englishCourse.StudentsQuantity()}");

englishCourse.RemoveStudent(p2);
// englishCourse.GetStudents();
// Console.WriteLine($"Current students quantity: {englishCourse.StudentsQuantity()}");
#endregion

#region Formatação de valores

//Formatação para tipo moeda
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal monetaryValue = 82.40M;
// Console.WriteLine($"{monetaryValue:C}"); //formatação pela região padrão
// Console.WriteLine(monetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //alterando a região para a formatação
// Console.WriteLine(monetaryValue.ToString("N9")); //formatação decimal com 9 casas decimais

//Formatação para porcentagens
double percentage = .3421;
// Console.WriteLine(percentage.ToString("P"));

//Formatação com separadores
int number = 123456;
// Console.WriteLine(number.ToString("##-##-##"));

//Formatação para datas
DateTime date = DateTime.Now;
// Console.WriteLine(date.ToString("dd/MM/yyyy"));
// Console.WriteLine(date.ToString("dddd")); //dia da semana
// Console.WriteLine(date.ToShortTimeString()); //somente a hora

//Convertendo datas
DateTime convertedDate = DateTime.Parse("31/12/2024");
// Console.WriteLine(convertedDate);

string stringDate = "2024-13-31 23:59";
bool conversionHasSuccess = DateTime.TryParseExact(stringDate, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AllowLeadingWhite, out DateTime parsedDate);

if(conversionHasSuccess){
    // Console.WriteLine(parsedDate);
} else {
    // Console.WriteLine("Data inválida");
}

#endregion

#region Leitura de arquivos e Tratamento de exceções

try
{
    string [] lines = File.ReadAllLines("Files/test/reeeeadFile.txt");

    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }
} 
catch(FileNotFoundException ex)
{
    // Console.WriteLine($"Ocorreu uma exceção específica: arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    // Console.WriteLine($"Ocorreu uma exceção específica: diretório não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    // Console.WriteLine($"Ocorreu uma exceção genérica: algo deu errado. {ex.Message}");
}
finally
{
    // Console.WriteLine("Continuando o programa...");
}

//Usando throw
// new ExceptionExample().Method1();

#endregion

#region Coleções

//Queue (Fila) - FIFO: First In First Out
Queue<int> myQueue = new Queue<int>();

myQueue.Enqueue(2);
myQueue.Enqueue(4);
myQueue.Enqueue(6);
myQueue.Enqueue(8);

foreach(int item in myQueue)
{
    // Console.WriteLine(item); //2 4 6 8
}

// Console.WriteLine($"Removendo o elemento: {myQueue.Dequeue()}"); //2

myQueue.Enqueue(10);

foreach(int item in myQueue)
{
    // Console.WriteLine(item); //4 6 8 10
}


//Stack (Pilha) - LIFO: Last In First Out
Stack<int> myStack = new Stack<int>();

myStack.Push(1);
myStack.Push(3);
myStack.Push(5);
myStack.Push(7);

foreach(int item in myStack)
{
    // Console.WriteLine(item); //7 5 3 1
}

// Console.WriteLine($"Removendo o elemento: {myStack.Pop()}"); //7

myStack.Push(11);

foreach(int item in myStack)
{
    // Console.WriteLine(item); //11 5 3 1
}

//Dictionary
Dictionary<string, string> states = new Dictionary<string, string>(); //tipo da chave, tipo do valor

states.Add("SP", "São Paulo");
states.Add("BA", "Bahia");
states.Add("MG", "Minas Gerais");

foreach(var item in states)
{
    // Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

//states.Add("BA", "Bahia"); = Unhandled exception. System.ArgumentException: An item with the same key has already been added.

// Console.WriteLine("----- Removendo um item -----");

states.Remove("BA");

foreach(var item in states)
{
    // Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

// Console.WriteLine("----- Alterando o valor de um item -----");

states["SP"] = "São Paulo Alterado";

foreach(var item in states)
{
    // Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

// Console.WriteLine("----- Procurando um item -----");

string key = "MG";

// Console.WriteLine($"Item buscado: {key}");

if(states.ContainsKey(key))
{
    // Console.WriteLine($"Chave {key} encontrada! Seu valor correspondente é {states[key]}");
}
else
{
    // Console.WriteLine($"Chave {key} não encontrada. É seguro adicionar essa chave");
}
#endregion

#region Tuplas

(int Id, string Name, string Surname) myTuple = (1, "Ana", "Walker");

Console.WriteLine($"ID: {myTuple.Id}");
Console.WriteLine($"Nome: {myTuple.Name}");
Console.WriteLine($"Sobrenome: {myTuple.Surname}");

ValueTuple<int, string, string> otherTupleExample = (2, "Gustavo", "Brito");

var otherTupleExample2 = Tuple.Create(3, "Júlia", "Barreto");

Console.WriteLine($"ID: {otherTupleExample.Item1}");
Console.WriteLine($"Nome: {otherTupleExample.Item2}");
Console.WriteLine($"Sobrenome: {otherTupleExample.Item3}");

//Tuplas em métodos
ReadFile file = new ReadFile();

var (success, fileLines, linesQuantity) = file.ReadAndReturnFile("Files/readFile.txt");

if(success)
{
    Console.WriteLine("Quantidade de linhas do arquivo: " + linesQuantity);
    foreach(string line in fileLines)
    {
        Console.WriteLine(line);
    }
}
else 
{
    Console.WriteLine("Não foi possível ler o arquivo.");
}

#endregion