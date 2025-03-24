//Funcao de saudação

void Saudacao(string nome)
{
    Console.WriteLine($"Olá, {nome}! Bem-vindo!");
}

Saudacao("Vinicius");


//Funcao de soma

float Soma(float num1, float num2)
{
    float total = num1 + num2;
    return total;
}

Console.WriteLine(Soma(5, 3));


//Funcao de mensagem simples

void MostrarMensagem()
{
    Console.WriteLine("Este é um programa de C# com funções");
}
MostrarMensagem();

//Caclulo de media
double CalcularMedia(double num1, double num2, double num3)
{
    double total = (num1 + num2 + num3)/3;
    return total;
}
Console.WriteLine("Média: "+ CalcularMedia(7.5, 8.0, 6.5));



//Numero eh par
bool EhPar (int num1)
{
    if (num1 % 2 == 0)
    {
        return true;
    }else
    {
        return false;
    }
    
}
EhPar(10);


//Conversao de temperatura

double CelsiusParaFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9 / 5) + 32;
    return fahrenheit;
}
Console.WriteLine(CelsiusParaFahrenheit(25));

//Contador de vogais

int ContarVogais(string palavra)
{
    int numvogais = 0;
    foreach (char i in palavra)
    {
        if (i == 'i' || i == 'a' || i == 'e' || i == 'o' || i == 'u')
        {
            numvogais++;
        }
    }
    return numvogais;
    
}
Console.WriteLine(ContarVogais("Programação"));

//