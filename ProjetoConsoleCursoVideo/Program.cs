Console.Write(1.2);
Console.WriteLine("Hello, World!");

Console.WriteLine("oi, tudo bem?");

Console.WriteLine(123456);

Console.Write("oiiiiiiiiiii");
Console.WriteLine("tudo bem");

Console.WriteLine("\tOi tudo bem?");

Console.WriteLine("oi \ntudo bem?");

// isso é um comentario

/*
 wewe
edwwe
dede
 */

string nome = "Eduardo";
int idade = 24;
double altura = 1.67;
bool vivo = false;
char letra = 'c';


Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(altura);
Console.WriteLine(letra);
Console.WriteLine(vivo);

//nom: nome idade: idade
Console.WriteLine("Nome: " + nome + " Idade: " + idade);

Console.WriteLine($"Nome:{nome} Idade:{idade}");

nome = "Crislaine Luana";
idade = 68;


Console.WriteLine($"Nome:{nome} Idade:{idade}");

const double pi = 3.14159;

//pi = 3.19; não pode colocar um outro valor dentro do PI

Console.WriteLine(pi);

double a = 3.14;
int b = Convert.ToInt32(a);

Console.WriteLine(a);
Console.WriteLine(a.GetType());
Console.WriteLine(b);
Console.WriteLine(b.GetType());

int c = 3;
double d = Convert.ToDouble(c);

Console.WriteLine(c);
Console.WriteLine(c.GetType());
Console.WriteLine(d);
Console.WriteLine(d.GetType());

//string a = "2";
//int b = Convert.ToInt32(a);

//Console.WriteLine(a);
//Console.WriteLine(a.GetType());
//Console.WriteLine(b);
//Console.WriteLine(b.GetType());

//string a = "true";
//bool b = Convert.ToBoolean(a);

//Console.WriteLine(a);
//Console.WriteLine(a.GetType());
//Console.WriteLine(b);
//Console.WriteLine(b.GetType());



Console.ReadKey();