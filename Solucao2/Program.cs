    using System;
    using SolucaoDesc;

    bool checknum = true;
    do {
        try
        {
            Console.WriteLine("Informe o valor:");
            float valorunit;
            valorunit = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o desconto");
            float desconto = float.Parse(Console.ReadLine()); 

            var calcularDesconto = new Descontos ();

            Console.WriteLine (calcularDesconto.CalcularDesconto(valorunit,desconto));

            checknum = false;

        }
        catch (System.Exception)
        {
            Console.WriteLine("Informe apenas numeros");
        }
    } while (checknum);
