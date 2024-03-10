using System;

class Program {

    static void Main(String[] args) {

         Console.WriteLine("*********************************************************");
         Console.WriteLine("*               Calculadora Simples                     *");
         Console.WriteLine("*********************************************************");

         menu();

         int @operator = int.Parse(Console.ReadLine());

         Console.WriteLine("Informe o 1ª numero: ");
         int number1 = int.Parse(Console.ReadLine());

         Console.WriteLine();                 
         
         Console.WriteLine("Informe o 2ª numero: ");
         int number2 = int.Parse(Console.ReadLine());

         int result = 0;

         switch(@operator) {

            case 1: result = add(number1, number2);
            break;

            case 2: result = sub(number1, number2);
            break;

            case 3: result = mult(number1, number2);
            break;

            case 4: result = div(number1, number2);
            break; 

            default: 
            Console.WriteLine("Error: Opção não valida");
            break; 
         
         }

         string msn = $"O resultado entre {number1} e {number2} é: {result}"; 
         Console.WriteLine(msn); 
    }

    public static void menu() {
         Console.WriteLine("Informe abaixo qual operação matematica desejada: ");
         Console.WriteLine("1 - Adição: ");
         Console.WriteLine("2 - Subtração: ");
         Console.WriteLine("3 - Multiplicação: ");
         Console.WriteLine("4 - Divisão: ");
    }
    
    public static int add(int x, int y) {
        return x + y;
    }

    public static int sub(int x, int y) {
        return x - y;
    }

    public static int mult(int x, int y) {
        return x * y;
    }

    public static int div(int x, int y) {
        return x / y;
    }
}