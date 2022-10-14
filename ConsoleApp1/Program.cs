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



//declarando variveis 

string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;


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


