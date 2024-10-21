using System;

class Program {
    public static void Main (string[] args)
    {
        Console.WriteLine("Estou aprendendo C# \nE também dotnet");
        Console.WriteLine("E Unity");
        //Console.WriteLine("Olá mundo");
        /*
            string - nome/palavra/frase
            int - número inteiro
            float - num real
            double - número real dupla precisão
            bool - variável lágica (true/false)
            char - caractere
        */

        //tipoDaVariavel nomeDaVariavel;
        //int idade;

        //nomeDaVariavel = valor
        //idade = 18;

        //tipoDaVariavel nomeDaVariavel = valor
        int idadeDoJoao = 18;
        Console.WriteLine(idadeDoJoao);

        //exercício 1 aula03
        //string nomePaciente;
        //int idadePaciente;
        //float pesoPaciente;
        //float imcPaciente;

        //exercício 2 aula03        
        //string nomeAluno;
        //int idadeAluno;
        //char anoAluno;
        //bool presencaAluno;

        bool isOn;
        isOn = true;
        //ison = true; (1)
        //isOn = false; (0)

        Console.WriteLine(isOn);

        int vida = 100; //usará 4 bytes
        //-2147483648 a 2147483647
        long num = 2147483648; //usará 16 bytes
        //-2^63 até 2^63 - 1
        short stamina = 100;
        uint idade = 19;

        Console.WriteLine(vida);
        Console.WriteLine(num);
        Console.WriteLine(stamina);
        Console.WriteLine(idade);

        float preco = 12.52F;
        double desconto = 2.50254;

        char caractere = 'a';
        char um = '1';
        char A = 'A';
        int numUm = 1;
        string escola = "CodiAcademy";
        Console.WriteLine("HelloWorld");

        Console.WriteLine(preco);
        Console.WriteLine(desconto);
        Console.WriteLine(caractere);
        Console.WriteLine(um);
        Console.WriteLine(A);
        Console.WriteLine(numUm);
        Console.WriteLine(escola);


        //Aula 04 - Exercícios

        /*

        EU FIZ:

        float c002 = 95.30F;
        float c005 = 85.20F;
        float c040 = 100.00F;
        float p032 = 80.00F;

        
        Console.WriteLine("C002 - Aulas de BackEnd = "+c002);  
        Console.WriteLine("C005 - Orientação a Objetos = "+c005); 
        Console.WriteLine("C040 - Front End em React = "+c040);
        Console.WriteLine("P032 - Laboratório de Programação = "+p032);
        */

        //Corrigindo

        string codigo1, codigo2, codigo3, codigo4;
        string disciplina1, disciplina2, disciplina3, disciplina4;
        float nota1, nota2, nota3, nota4;

        codigo1 = "C002";
        codigo2 = "C005";
        codigo3 = "C040";
        codigo4 = "P032";

        disciplina1 = "Aulas de BackEnd";
        disciplina2 = "Orientação a objetos";
        disciplina3 = "Front End em React";
        disciplina4 = "Laboratório de Programação";

        nota1 = 95.30f;
        nota2 = 85.20f;
        nota3 = 100.00f;
        nota4 = 80.00f;

        Console.WriteLine(codigo1+" - "+disciplina1+" - "+nota1);
        Console.WriteLine(codigo2+" - "+disciplina2+" - "+nota2);
        Console.WriteLine(codigo3+" - "+disciplina3+" - "+nota3);
        Console.WriteLine(codigo4+" - "+disciplina4+" - "+nota4);

        //Exercicio 2 (EU FIZ):
        string tipoPao1, tipoPao2, tipoPao3;
        int estoqueTipo1, estoqueTipo2, estoqueTipo3;
        float valorTipo1, valorTipo2, valorTipo3;

        tipoPao1 = "Pão de Sal";
        tipoPao2 = "Pão de Batata";
        tipoPao3 = "Pão recheado";

        estoqueTipo1 = 200;
        estoqueTipo2 = 150;
        estoqueTipo3 = 80;

        valorTipo1 = 0.50f;
        valorTipo2 = 0.7f;
        valorTipo3 = 1.5f;

        Console.WriteLine(tipoPao1+" - "+estoqueTipo1+" - "+valorTipo1);
        Console.WriteLine(tipoPao2+" - "+estoqueTipo2+" - "+valorTipo2);
        Console.WriteLine(tipoPao3+" - "+estoqueTipo3+" - "+valorTipo3);

        //Aula 05
        string nome;
        nome = Console.ReadLine();
        Console.WriteLine("Seja bem vindo " + nome);

        //A funcao READLINE le somente variaveis tipo string, por isso converter
        int idadeX;
        idadeX = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sua Idade e " + idadeX);

        /*
        float flo = Convert.ToFloat();
        double dou = Convert.ToDouble();
        string str = stringConvert.ToString();
        bool b = Convert.ToBoolean();
        char c = Convert.ToChar();
        */
        //Exercicio 1 - Aula 05 (EU FIZ)
        string meuNome;
        int minhaIdade;

        Console.WriteLine("Digite seu NOME");
        meuNome = Console.ReadLine();

        Console.WriteLine("Digite sua IDADE");
        minhaIdade = Convert.ToInt32(Console.ReadLine());
        // OU Int16.Parse(Console.ReadLine());
        /* Existem: int8, int16, int32, int64
        Converte a representação de cadeia de caracteres de um número no inteiro com sinal de 32 bits equivalente.
        */

        Console.WriteLine("Olá, meu nome é " + meuNome + ", tenho " + minhaIdade + " anos e estou estudando C# na Codi Academy!");

        //Exercicio 2 - Aula 05 (EU FIZ)
        string nomeProduto;
        float valorProduto;

        Console.WriteLine("Digite o NOME do produto");
        nomeProduto = Console.ReadLine();

        Console.WriteLine("Digite o VALOR do produto");
        valorProduto = Convert.ToSingle(Console.ReadLine());
        //OU valorProduto = float.Parse(Console.ReadLine());
        //Parece que a aulas esta errada ou desatualizada
        
        Console.WriteLine("O produto " + nomeProduto + " custa R$" + valorProduto + " reais.");

        // Aula 06

        int a = 15, b = 10, c;
        c = a + b;
        Console.WriteLine("Adição: " + c);

        c = a - b;
        Console.WriteLine("Subtração: " + c);

        c = a * b;
        Console.WriteLine("Multiplicação: " + c);

        c = a / b;
        Console.WriteLine("Divisão: " + c);

        c = a % b;
        Console.WriteLine("Resto de uma divisão inteira: " + c);


        // Class 06 - Exercise
        // 01 (ok)

        Console.WriteLine("Enter the total number of toys: ");
        int nToys = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the total number of children in the group: ");
        int tKids = Convert.ToInt32(Console.ReadLine());
        int toysPerKid = nToys / tKids;
        int toysLeft = nToys % tKids;
        
        Console.WriteLine("Below are resume the donation: ");
        Console.WriteLine("Total Toys: " + nToys);
        Console.WriteLine("Total Children: " + tKids);
        Console.WriteLine("Toys Per Child: " + toysPerKid);
        Console.WriteLine("Toys Left: " + toysLeft);

        // 02 (ok)

        Console.WriteLine("Enter your balance below: ");
        int balance = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your expense 1 below: ");
        int expense1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your expense 2 below: ");
        int expense2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your expense 3 below: ");
        int expense3 = Convert.ToInt32(Console.ReadLine());

        int result = balance - (expense1 + expense2 + expense3);

        Console.WriteLine("This is your updated balance: " + result);

        // Solved exercise
        float saldo, gasto1, gasto2, gasto3;
        Console.WriteLine("Digite o saldo total");
        saldo = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o gasto 1");
        gasto1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o gasto 2");
        gasto2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o gasto 3");
        gasto3 = float.Parse(Console.ReadLine());
        saldo = saldo - gasto1 - gasto2 - gasto3;
        Console.WriteLine("O saldo final é de R$" + saldo);


        // Class 07 - Assignment
        string nome = "Aprendendo";
        int idade = 19;
        idade -= 5;
        idade = idade + 5;
        // ou
        idade += 5;

        // Class 08 - Increment and Decrement
        string nome = "Aprendendo";
        int idade = 19;
        idade = idade + 19;
        idade++; //idade = 20
        idade--; //idade = 19
        int idade = 19;
        int NovaIdade;
        NovaIdade = idade++; //novaIdade = 19, idade = 20
        NovaIdade = ++idade; // novaIdade = 21, idade = 21

        // Class 08 - Exercises
        //01 (ok)
        
        int intValue, newValue = 0;
        Console.WriteLine("Enter an integer value: ");
        intValue = Int16.Parse(Console.ReadLine());
        newValue += intValue;
        newValue++;
        newValue++;
        Console.WriteLine("The new value is: " + newValue);
        Console.WriteLine("The old value is: " + intValue);

        // Solved Exercise
        int var1, var2 = 0;
        Console.WriteLine("Digite o valor da variavel");
        var1 = Int16.Parse(Console.ReadLine());
        var2 += var1;
        var2++;
        var2++;
        Console.WriteLine(var2 + " " + var1);

        // 02 (ok)

        Faça um programa que leia do teclado um valor inteiro e em seguida, usando o decremento, reduza o número lido em 3 unidades, ao final imprima a variável.

        int intValue, newValue = 0;
        Console.WriteLine("Enter an integer value: ");
        intValue = Int16.Parse(Console.ReadLine());
        newValue += intValue;
        newValue--;
        newValue--;
        Console.WriteLine("The new value is: " + newValue);
        Console.WriteLine("The old value is: " + intValue);

        // Class 09 - Comparison Operators

        int age = 20;
        bool isAdult;
        age == 18;

        // Class 09 - Exercises
        // 01 (ok)

        float height, minHeight = 1.50f;

        Console.WriteLine("Enter your height: ");
        height = float.Parse(Console.ReadLine());

        if (height >= minHeight)
        {
            Console.WriteLine("You are allowed to enter the bar");
        }
        else
        {
            Console.WriteLine("You are not allowed to enter the bar");
        }

        // Solved Exercise

        float altura;
        bool minima;
        Console.WriteLine("Digite a altura");
        altura = float.Parse(Console.ReadLine());
        minima = altura >= 1.50;

        // 02
        Faça um programa que leia do teclado um valor inteiro correspondente a idade de um possível aluno da Codi Academy, depois faça uma comparação com a idade mínima necessária (14 anos) e atribua este resultado a uma variável lógica.

        





    }
}