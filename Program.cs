bool x = true;
if (x == true)
{
    do
    {
        Console.WriteLine("\t\tConversor de temperatura\n");
        Console.WriteLine("\tCelsius\t\tKelvin\t\tFarenheit\n");
        Console.WriteLine("\nFeito por Pedro Luca Galvão Couto");
        Console.WriteLine("\n2024\n");
        Console.WriteLine("\nQual das opções abaixo melhor atende a sua necessidade?");
        Console.WriteLine("Converter Fahrenheit para Celsius digite 1");
        Console.WriteLine("Converter Fahrenheit para Kelvin digite 2");
        Console.WriteLine("Converter Celsius para Fahrenheit digite 3");
        Console.WriteLine("Converter Celsius para Kelvin digite 4");
        Console.WriteLine("Converter Kelvin para Celsius digite 5");
        Console.WriteLine("Converter Kelvin para Fahrenheit digite 6");
        Console.WriteLine("Aperte qualquer outra tecla para sair");

        string opcao = Console.ReadLine();

        if (opcao == "1")
        {
            Console.WriteLine("\nVocê selecionou o convertor de Fahrenheit para Celsius\n");
            Console.WriteLine("Informe a temperatura:");
            float temperatura = float.Parse(Console.ReadLine());
            float farenheit = temperatura;

            float result = (farenheit - 32) * 5 / 9;
            result = (float)Math.Round(result, 2);

            Console.WriteLine($"A temperatura: {temperatura}° Fahrenheit equivale a {result}° Celsius");
        }
        if (opcao == "2")
        {
            Console.WriteLine("\nVocê selecionou o convertor de Fahrenheit para Kelvin\n");
            Console.WriteLine("Informe a temperatura:");
            float temperatura = float.Parse(Console.ReadLine());
            float farenheit = temperatura;

            float result = (farenheit - 32) * 5 / 9 + 273.15f;
            result = (float)Math.Round(result, 2);

            Console.WriteLine($"A temperatura: {temperatura}° Fahrenheit equivale a {result}° Kelvin");
        }

        if (opcao == "3")
        {
            Console.WriteLine("\nVocê selecionou o convertor de Celsius para Fahrenheit\n");
            Console.WriteLine("Informe a temperatura:");
            float temperatura = float.Parse(Console.ReadLine());
            float celsius = temperatura;

            float result = celsius * 1.18f + 32;
            result = (float)Math.Round(result, 2);

            Console.WriteLine($"A temperatura: {temperatura}° Celsius equivale a {result}° Fahrenheit");

        }

        if (opcao == "4")
        {
            Console.WriteLine("\n Você selecionou o convertor de Celsius para Kelvin\n");
            Console.WriteLine("Informe a temperatura:");
            float temperatura = float.Parse(Console.ReadLine());
            float celsius = temperatura;

            float result = celsius + 273.15f;
            result = (float)Math.Round(result, 2);

            Console.WriteLine($"A temperatura: {temperatura}° Celsius equivale a {result}° Kelvin");
        }

        if (opcao == "5")
        {
            Console.WriteLine("\nVocê selecionou o convertor de Kelvin para Celsius\n");
            Console.WriteLine("Informe a temperatura:");
            float temperatura = float.Parse(Console.ReadLine());
            float kelvin = temperatura;

            float result = kelvin - 273.15f;
            result = (float)Math.Round(result, 2);

            Console.WriteLine($"A temperatura: {temperatura}° Kelvin equivale a {result}° Celsius");
        }

        if (opcao == "6")
        {
            Console.WriteLine("\nVocê selecionou o convertor de Kelvin para Celsius\n");
            Console.WriteLine("Informe a temperatura:");
            float temperatura = float.Parse(Console.ReadLine());
            float kelvin = temperatura;

            float result = (kelvin - 273.15f) * 1.8f + 32;
            result = (float)Math.Round(result, 2);

            Console.WriteLine($"A temperatura: {temperatura}° Kelvin equivale a {result}° Celsius");
        }
        
        
        
        Console.WriteLine("\nDeseja continuar?");
        Console.WriteLine("Digite S para sim e qualquer outra tecla para parar");
        string escolha = Console.ReadLine();

        if (escolha == "s" || escolha == "S")
        {
            x = true;
        }
        else
        {
            x =false;
        }

    } while (x);

}





