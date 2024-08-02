using System;

class Calculator
{
    public static void init()
    {
        Console.WriteLine("\nSelecione a operação matemática" +
            "\n1 - Soma" +
            "\n2 - Subtração" +
            "\n3 - Multiplicação" +
            "\n4 - Divisão");
        int operation = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nInsira o valor 1: ");
        float number1 = float.Parse(Console.ReadLine());

        Console.Write("\nInsira o valor 2: ");
        float number2 = float.Parse(Console.ReadLine());

        float result = calculate(operation, number1, number2);

        if (result == float.MaxValue)
        {
            Console.WriteLine("\nA Operação selecionada é inválida");
        }
        else
        {
            Console.WriteLine($"\nO calculo entre {number1} e {number2} é: {result}");
        }
    }
    private static float calculate(int op, float num1, float num2)
    {
        switch (op)
        {
            case 1:
                return num1 + num2;
            case 2:
                return num1 - num2;
            case 3:
                return num1 * num2;
            case 4:
                return num1 / num2;
            default:
                return float.MaxValue;
        }
    }
}

class HelloWorld
{
    public static void init()
    {
        Console.WriteLine("                                                                                                                     ,---,\r\n                                                                                                                  ,`--.' |\r\n  ,---,                  ,--,      ,--,                                                       ,--,                |   :  :\r\n,--.' |                ,--.'|    ,--.'|                                                     ,--.'|          ,---, '   '  ;\r\n|  |  :                |  | :    |  | :       ,---.              .---.    ,---.     __  ,-. |  | :        ,---.'| |   |  |\r\n:  :  :                :  : '    :  : '      '   ,'\\            /. ./|   '   ,'\\  ,' ,'/ /| :  : '        |   | : '   :  ;\r\n:  |  |,--.    ,---.   |  ' |    |  ' |     /   /   |        .-'-. ' |  /   /   | '  | |' | |  ' |        |   | | |   |  '\r\n|  :  '   |   /     \\  '  | |    '  | |    .   ; ,. :       /___/ \\: | .   ; ,. : |  |   ,' '  | |      ,--.__| | '   :  |\r\n|  |   /' :  /    /  | |  | :    |  | :    '   | |: :    .-'.. '   ' . '   | |: : '  :  /   |  | :     /   ,'   | ;   |  ;\r\n'  :  | | | .    ' / | '  : |__  '  : |__  '   | .; :   /___/ \\:     ' '   | .; : |  | '    '  : |__  .   '  /  | `---'. |\r\n|  |  ' | : '   ;   /| |  | '.'| |  | '.'| |   :    |   .   \\  ' .\\    |   :    | ;  : |    |  | '.'| '   ; |:  |  `--..`;\r\n|  :  :_:,' '   |  / | ;  :    ; ;  :    ;  \\   \\  /     \\   \\   ' \\ |  \\   \\  /  |  , ;    ;  :    ; |   | '/  ' .--,_\r\n|  | ,'     |   :    | |  ,   /  |  ,   /    `----'       \\   \\  |--\"    `----'    ---'     |  ,   /  |   :    :| |    |`.\r\n`--''        \\   \\  /   ---`-'    ---`-'                   \\   \\ |                           ---`-'    \\   \\  /   `-- -`, ;\r\n              `----'                                        '---\"                                       `----'      '---`\"\r\n");
    }
}

class ParOuImpar
{
    public static void init()
    {
        Console.WriteLine("Insira o valor para verificar: ");
        float num1 = float.Parse(Console.ReadLine());

        float result = verify(num1);

        if (result == 0f)
        {
            Console.WriteLine("O Resultado é Par");
        }
        else
        {
            Console.WriteLine("O Resultado é Ímpar");
        }
    }

    private static float verify(float num)
    {
        return num % 2;
    }
}

class Programa
{
    private static bool exit_program = false;
    public static void Main(string[] args)
    {
        while (!exit_program)
        {
            Console.WriteLine("\nSelecione as opções\n" +
            "\n1 - Calculadora" +
            "\n2 - Hello World" +
            "\n3 - Par ou Ímpar" +
            "\n4 - Exit");
            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Calculator.init();
                    break;
                case 2:
                    HelloWorld.init();
                    break;
                case 3:
                    ParOuImpar.init();
                    break;
                case 4:
                    exit_program = true;
                    break;
            }
        }
    }
}

