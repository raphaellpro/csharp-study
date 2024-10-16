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

        

        // Class 07 - Assignment

    }
}