using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}\n");

num1 = 10;
num2 = 5;

Console.WriteLine($"{num1} - {num2} = {c.Subtrair(num1, num2)}\n");

num1 = 5;
num2 = 10;

Console.WriteLine($"{num1} x {num2} = {c.Multiplicar(num1, num2)}\n");

num1 = 10;
num2 = 5;

Console.WriteLine($"{num1} / {num2} = {c.Dividir(num1, num2)}");