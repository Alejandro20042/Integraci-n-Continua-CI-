namespace Logica;

public class Calculadora
{
    public int Sumar(int a, int b) => a + b;

    public int Dividir(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
}