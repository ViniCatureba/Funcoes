//Funcoes

// Faz uma multiplicacao entre 2 numeros



//Criei uma funcao chamada Fazer multiplicacao
// <TIPO DE RETORNO> <Nome da funcao> () { }
double FazerMultiplicacao()
{
    double num1 = 7;
    double num2 = 9;

    double resultado = num1 * num2;

    return resultado;
    //returno - a saida da funcao
}


FazerMultiplicacao();

Console.WriteLine(FazerMultiplicacao);






// Parenteses ' Entrada a funcao ( oque ela recebe)

double Multiplicar(double numero1, double numero2)
{
    double resultado = numero1 * numero2;

    return resultado;
}

Console.WriteLine(Multiplicar(2,4));



// Crie uma funcao de soma

double Soma(double num1, double num2)
{
    return num1 + num2;
}
Console.WriteLine(Soma(1,5));