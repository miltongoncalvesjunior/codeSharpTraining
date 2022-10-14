// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Hello, World!");
//Console.Write("Congratulations!");
//Console.Write("");
//Console.Write("You wrote your first lines of code!");

//a linguagem considera os espaço, e WriteLine pula linha 



Console.WriteLine("This is the first line.");
Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");

//valores literais 
Console.WriteLine('b');

//teste de erro valor literal Console.WriteLine('Hello World!');
// isso oque porque o C# está esperando 1 valor literal sendo que oferecemos 12
// error type (1,19): error CS1012: Too many characters in character literal



//Gravar um literal int no console
Console.WriteLine(123);


// Gravar um literal decimal no console
Console.WriteLine(12.30m);
//o m é chamado de sufixo literal. O sufixo literal informa ao compilador que você deseja trabalhar com um valor do tipo decimal.
//Sem o sufixo literal m, o número decimal do exemplo anterior será tratado como o tipo double pelo compilador e a saída será 12.3.


// Gravar um literal bool no console
Console.WriteLine(true);
Console.WriteLine(false);



//declarando variveis 

//string firstName;
//char userOption;
//int gameScore;
//decimal particlesPerMillion;
//bool processedCustomer;


//configurar e obter valores de variáveis
//Como as variáveis são contêineres de armazenamento temporário para dados, elas devem ser gravadas e lidas.
// você declarará uma variável, atribuirá um valor a ela, recuperará seu valor e muito mais.


//declarar uma variável e atribuir um valor a ela   
//string firstName;
//firstName = "bob";


//recuperar um valor armazenado na variável
//Console.WriteLine(firstName);


//reatribuir o valor de uma variável
//firstName = "Beth";
//Console.WriteLine(firstName);
//firstName = "Conrad";
//Console.WriteLine(firstName);
//firstName = "Grant";
//Console.WriteLine(firstName);


//inicializar a variável
//string firstName = "bob";
//Console.WriteLine(firstName);



//Variáveis locais de tipo implícito
//correct
//var message = "Hello world!";
//incorrect 
//var message = "Hello World!";
//message = 10.0m;
//var message;

//string firstName = "Bob";
//var message = "Hello!";
//Console.Write( message, firstName);


string firstName = "Bob";
int messageInbox = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(firstName);
Console.Write("! You Have ");
Console.Write(messageInbox);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" Celsius ");




