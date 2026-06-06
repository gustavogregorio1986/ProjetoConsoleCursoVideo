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

//string nome = "Eduardo";
//int idade = 24;
//double altura = 1.67;
//bool vivo = false;
//char letra = 'c';


//Console.WriteLine(nome);
//Console.WriteLine(idade);
//Console.WriteLine(altura);
//Console.WriteLine(letra);
//Console.WriteLine(vivo);

//nom: nome idade: idade
//Console.WriteLine("Nome: " + nome + " Idade: " + idade);

//Console.WriteLine($"Nome:{nome} Idade:{idade}");

//nome = "Crislaine Luana";
//idade = 68;


//Console.WriteLine($"Nome:{nome} Idade:{idade}");

const double pi = 3.14159;

//pi = 3.19; não pode colocar um outro valor dentro do PI

Console.WriteLine(pi);

//double a = 3.14;
//int b = Convert.ToInt32(a);

//Console.WriteLine(a);
//Console.WriteLine(a.GetType());
//Console.WriteLine(b);
//Console.WriteLine(b.GetType());

//int c = 3;
//double d = Convert.ToDouble(c);

//Console.WriteLine(c);
//Console.WriteLine(c.GetType());
//Console.WriteLine(d);
//Console.WriteLine(d.GetType());

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

//Console.WriteLine("Qual seu nome?");
//string nome = Console.ReadLine();

//Console.WriteLine("Qual sua idade?");
//int idade = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O seu nome é: {nome} e sua idade é {idade} anos!");

//int numero = 1;


//numero = numero + 1;
//Console.WriteLine(numero);
//numero = numero - 1;
//Console.WriteLine(numero);
//numero -= 10;
//Console.WriteLine(numero);
//numero--;

//Console.WriteLine(numero);

//numero = numero + 2;
//Console.WriteLine(numero);

//numero *= 2;
//Console.WriteLine(numero);

//numero = numero / 2;

//Console.WriteLine(numero);

//numero /= 2;
//Console.WriteLine(numero);

//int resto;

//int numero = 10;

//resto = numero % 4;

//Console.WriteLine(resto);

//double x = 3;

//double w = -5;
//double a = Math.Pow(x, 2);
//double z = 4.5;
//Console.WriteLine(a);

//double y = 81;
//double b = Math.Sqrt(y); 
//Console.WriteLine(b);
//double c = Math.Abs(b);
//Console.WriteLine(w);
//double d = Math.Round(w);
//Console.WriteLine(z);
//double e = Math.Ceiling(z);
//Console.WriteLine(e);
//double f = Math.Floor(z);
//Console.WriteLine(f);
//double g = Math.Max(y, x);
//Console.WriteLine(g);

//int variavell = 0;
//Random random = new Random();

//int num = random.Next(1,7);
//double numDecimal = random.NextDouble();

//Console.WriteLine(num);
//Console.WriteLine(numDecimal);

//Console.WriteLine("Digite o primeiro numero: ");
//int numero1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o segundo numero: ");
//int numero2 = Convert.ToInt32(Console.ReadLine());

//int resultado = numero1 * numero2;

//Console.WriteLine($"O resultado é {resultado}");

//Console.WriteLine("Digite o primeiro nome: ");
//string nome1 = Console.ReadLine();

//Console.WriteLine("Digite o segundo nome: ");
//string nome2 = Console.ReadLine();

//Console.WriteLine($"O nome compelto que é {nome1} {nome2}");

//Console.WriteLine("Digite o primeiro numero ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o segundo numero ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//int resultado1 = num1 + num2;

//Console.WriteLine($"O resulktado é {resultado}")

string nomeCompleto = "Crislaine Luana";
string numeroTelefone = "41-98888-8888";

nomeCompleto = nomeCompleto.ToUpper();

nomeCompleto = nomeCompleto.ToLower();
Console.WriteLine(nomeCompleto);

//numeroTelefone = numeroTelefone.Replace("-","/");

//Console.WriteLine(numeroTelefone);

numeroTelefone = numeroTelefone.Replace("-", "");

Console.WriteLine(numeroTelefone);

Console.WriteLine(nomeCompleto.Length);

string primeiroNome = nomeCompleto.Substring(0, 9);

Console.WriteLine(primeiroNome);

string ultimoNome = nomeCompleto.Substring(10, 5);

Console.WriteLine(ultimoNome);

//Console.WriteLine("Digite sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//if(idade >= 100)
//{
//    Console.WriteLine("Você é muito velho");
//}
//else if (idade >= 100)
//{
//    Console.WriteLine("Você é de maior.");
//}
//else
//{
//    Console.WriteLine("Você é de menor.");
//}

//Console.WriteLine("Cheguei aqui no final.");

// > maior que
//>= maior ou igual 
//<= menor ou igual
//== igual a
//!= diferente

//int numero = 15;

//if (numero > 15)
//{
//    Console.WriteLine("você entrou.");
//}
//else
//{
//    Console.WriteLine("você não entrou.");
//}

//if (numero >= 15)
//{
//    Console.WriteLine("você entrou.");
//}
//else
//{
//    Console.WriteLine("você não entrou.");
//}

//if (numero <= 15)
//{
//    Console.WriteLine("você entrou.");
//}
//else
//{
//    Console.WriteLine("você não entrou.");
//}

//if (numero == 15)
//{
//    Console.WriteLine("você nretrou.");
//}
//else
//{
//    Console.WriteLine("você não entrou.");
//}

//if (numero == 16)
//{
//    Console.WriteLine("você nretrou.");
//}
//else
//{
//    Console.WriteLine("você não entrou.");
//}

//if (numero != 16)
//{
//    Console.WriteLine("você nretrou.");
//}
//else
//{
//    Console.WriteLine("você não entrou.");
//}

//Console.WriteLine("Qual é o dia da semana?? ");
//string dia = Console.ReadLine();

//switch (dia)
//{ 
//    case "segunda":
//        Console.WriteLine("Hoje é segunda-feira.");
//        break;
//    case "terça":
//        Console.WriteLine("Hoje é terça-feira.");
//        break;
//    case "quarta":
//        Console.WriteLine("Hoje é quarta-feira.");
//        break;
//    case "quinta":
//        Console.WriteLine("Hoje é quinta-feira.");
//        break;
//    case "sexta":
//        Console.WriteLine("Hoje é sexta-feira.");
//        break;
//    default:
//        Console.WriteLine($"{dia} não é um dia da semana.");
//        break;
//}

//Console.WriteLine("Digite sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Você é administrador: ");
//bool adm = Convert.ToBoolean(Console.ReadLine());

//if(idade >= 18 && adm)
//{
//    Console.WriteLine("Você pode acessar o sistema.");
//}
//else
//{
//    Console.WriteLine("Não atigir as regras.");
//}

//Console.WriteLine("Você é administrador: ");
//bool adm = Convert.ToBoolean(Console.ReadLine());

//if (!adm)
//{
//    Console.WriteLine("Você pode acessar o sistema.");
//}
//else
//{
//    Console.WriteLine("Não atigir as regras.");
//}

//Console.WriteLine(primeiroNome);

//Console.WriteLine("Qual nome?");
//string nome = Console.ReadLine();

//while(nome == "")
//{
//    Console.WriteLine("Nome inválido. Qual nome?");
//    nome = Console.ReadLine();
//}

//Console.WriteLine("Ola " + nome);

for(int index = 0; index <= 10; index++)
{
    Console.WriteLine(index);
}

Console.WriteLine("decremento");

for (int index = 10; index >= 0; index--)
{
    Console.WriteLine(index);
}

/*

   masted logos 

 */

//Console.Write("Quantas linhas?:  ");
//int linhas = Convert.ToInt32(Console.ReadLine());

//Console.Write("Quantas colunas?:  ");
//int colunas = Convert.ToInt32(Console.ReadLine());

//Console.Write("Qual o simbolo?: ");
//string simbolo = Console.ReadLine();


//for(int i = 0; i < linhas; i++)
//{
//    for(int j = 0; j < colunas; j++)
//    {
//        Console.Write(simbolo);
//    }
//    Console.WriteLine();
//}


//Random random = new Random();

//bool jogarNovamente = true;
//int min = 1;
//int max = 100;
//int chute;
//int numero;
//int tentativas;
//string resposta;

//while(jogarNovamente)
//{
//    chute = 0;
//    tentativas = 0;
//    numero = random.Next(min, max + 1);
//    resposta = "";

//    while (chute != numero)
//    {
//        Console.Write($"Adivcinhe o numero entre {min} e {max}: ");
//        chute = Convert.ToInt32(Console.ReadLine());
//        tentativas++;
//        if (chute < numero) 
//        {
//            Console.WriteLine("Muito baixo! Tente novamente.");
//        }
//        else if (chute > numero)
//        {
//            Console.WriteLine("Muito alto! Tente novamente.");
//        }
//        else
//        {
//            Console.WriteLine($"Parabéns! Você acertou o número {numero} em {tentativas} tentativas.");
//        }
//    }
//}

/*

   Array - Variavel que pode armazenar multiplos valores e não apenas um.

 */

string[] frutas = { "laranja", "Uva", "limão", "kiwi" };

for(int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}

Console.WriteLine("Foreach");

foreach(string fruta in frutas)
{
    Console.WriteLine(fruta);
}

/*

  Métodos - Uma forma de reutilizar codigos

 */

FelizAniversario();
FelizAniversario();
FelizAniversario();
FelizAniversario();
FelizAniversario();
FelizAniversario();

static  void  FelizAniversario()
{
    Console.WriteLine("Parabéns pra você");
    Console.WriteLine("Happy birtday to you");
    Console.WriteLine("Happy birtday dear you");
    Console.WriteLine("Feliz anivesario");
    Console.WriteLine("Feliz anivesario");
    Console.WriteLine();
}

Console.ReadKey();