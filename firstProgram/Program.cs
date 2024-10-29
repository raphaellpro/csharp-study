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


        //Aula 04 - Exercises

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

        //Exercicio 2 (I do!):
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
        //Exercicio 1 - Aula 05 (I do!)
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

        //Exercicio 2 - Aula 05 (I do!)
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
        // 01 (OK!)

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

        // 02 (OK!)

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
        //01 (OK!)
        
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

        // 02 (OK!)

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
        // 01 (OK!)

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

        // 02 (ok!)

        int  ageStudent;
        bool minAge;
        
        Console.WriteLine("Enter your age: ");
        ageStudent = Int16.Parse(Console.ReadLine());
        minAge = ageStudent >= 14;
        Console.WriteLine(minAge);

        // Solved Exercise


        // Class 10 - Logical Operators

        int age = 20;
        bool ticket = false;
        bool permission = true;
        // bool entryPermitted = age >= 18 || permission = true;
        // bool entryBlocked = !(age >= 18);
        // bool entryPermitted = (age >= 18 || permission) && ticket = true;
        
        // ! => not (Negation operator)

        // Class 11 - IF and ELSE

        if((age >= 18 || permission) && ticket)
        {
            Console.WriteLine("Entry Allowed!");
        }
        else if(!ticket){
            // Console.WriteLine("Entry Blocked");
            Console.WriteLine("The ticket is missing!");
        }
        else {
            Console.WriteLine("Age or permission denied!");
        }

        // Class 11 - Exercises
        // 01 (OK!)

        int ageStudent, minAge = 14;

        Console.WriteLine("Enter your age: ");
        ageStudent = Int16.Parse(Console.ReadLine());

        if (ageStudent < minAge) {
            Console.WriteLine("You are not of minimum age!");
        } else {
            Console.WriteLine("Welcome to Codi Academy!");        
        }

        // 02 (OK!)

        float side1, side2, side3, sumSides1, sumSides2, sumSides3;

        Console.WriteLine("Enter side 1: ");
        side1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 2: ");
        side2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 3: ");
        side3 = float.Parse(Console.ReadLine());

        sumSides1 = side1 + side2;
        sumSides2 = side1 + side3;
        sumSides3 = side3 + side2;

        if (sumSides1 > side3 && sumSides2 > side2 && sumSides3 > side1) {
            Console.WriteLine("The measurements form a triangle!");
        } else {
            Console.WriteLine("The measurements DO NOT form a triangle!");
        }

        // Eliminate unnecessary variables

        float side1, side2, side3;

        Console.WriteLine("Enter side 1: ");
        side1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 2: ");
        side2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 3: ");
        side3 = float.Parse(Console.ReadLine());

        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1) {
            Console.WriteLine("The measurements form a triangle!");
        } else {
            Console.WriteLine("The measurements DO NOT form a triangle!");
        }


        // Class 12 - Switch

        char semaforo; // g, y, r

        switch (semaforo)
        {
            case 'g':
            // code
            Console.WriteLine("GO!");
            break;
            case 'y':
            // code
            Console.WriteLine("ATTENTION!");
            break;
            case 'r':
            // code
            Console.WriteLine("STOP!");                
            break;
        }

        // Class 12 - Exercises
        // 01 (OK!)

      int product;

      Console.WriteLine("Enter the product code 1 - 5: ");
      product = Int16.Parse(Console.ReadLine());

      switch (product)
      {
        case 1:
          Console.WriteLine("Non-perishable food");
          break;
          case 2:
          Console.WriteLine("Perishable food");
          break;
          case 3:
          Console.WriteLine("Clothing");
          break;
          case 4:
          Console.WriteLine("Cleaning");
          break;
          case 5:
          Console.WriteLine("Cosmetic");
          break;
      }

      // Solved Exercise (12)
      
            int codigo;
      Console.WriteLine("Digite o código do produto");
      codigo = Int16.Parse(Console.ReadLine());
      switch (codigo)
      {
      case 1:
      Console.WriteLine("Alimento não perecível");
      break;
      case 2:
      Console.WriteLine("Alimento Perecível");
      break;
      case 3:
      Console.WriteLine("Vestuário");
      break;
      case 4:
      Console.WriteLine("Limpeza");
      break;
      case 5:
      Console.WriteLine("Cosmético");
      break;

      default:
      Console.WriteLine("Código inválido");
      break;
      }

    // Class 13 - Repetition Structures

    int after = 0;
    int endAfter = 10;

    while(after <= endAfter)
    {
        Console.WriteLine("Your current position is: " + after)
        pos++;
    }

    do {
        Console.WriteLine("Your current position is: " + after)
    } while (after <= endAfter);

    int endAfter = 10;

    for (int after = 0; after <= endAfter; after++)
    {
        Console.WriteLine("Your current position is " + after);
    }

    // Class 13 - Exercises
    // 01 (OK!)

        int product;
        do {
        Console.WriteLine("Enter the product code 1 - 5: ");
        product = Int16.Parse(Console.ReadLine());

        switch (product)
        {
            case 1:
            Console.WriteLine("Non-perishable food");
            break;
            case 2:
            Console.WriteLine("Perishable food");
            break;
            case 3:
            Console.WriteLine("Clothing");
            break;
            case 4:
            Console.WriteLine("Cleaning");
            break;
            case 5:
            Console.WriteLine("Cosmetic");
            break;
            default:
            Console.WriteLine("Invalid Code");
            break;
        }
          
        } while (product != 0);

        if (product == 0) {
          Console.WriteLine("You stopped the program");
        }

    // 02 (OK!)
    
    float side1, side2, side3;

    do {
    Console.WriteLine("Enter side 1: ");
    side1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter side 2: ");
    side2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter side 3: ");
    side3 = float.Parse(Console.ReadLine());
    
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1) {
            Console.WriteLine("The measurements form a triangle! (The program will now end!!)");
        } else {
            Console.WriteLine("The measurements DO NOT form a triangle!");
            }
        } while (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1);

    // Solved Exercise (13.2)

    float lado1 = 3, lado2 = 18, lado3 = 5;
    while (lado1 > lado2 + lado3 && lado2 > lado1 + lado3 &&
    lado3 > lado1 + lado2)
    {
    Console.WriteLine("Digite um dos lados do triângulo");
    lado1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite um dos lados do triângulo");
    lado2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite um dos lados do triângulo");
    lado3 = float.Parse(Console.ReadLine());
    }

    // Class 14 - Flow Controllers
    int pos = 0, endPos = 10, enemyPos = 6;

    while (pos <= endPos)
    {
        pos++;

        if (pos == itemPos)
        {
            Console.WriteLine("Item found.");
            continue;
        }

        if (pos == enemyPos)
        {
            Console.WriteLine("Collision with enemy.");
            break;
        }
        Console.WriteLine("Your current position is: " + pos);
    }

    Console.WriteLine("Game Over");

    // Class 14 - Exercises
    // 01 (OK!)

    int velCar1, velCar2, lap;

    velCar1 = 200;
    velCar2 = 180;
    laps = 0;

    while (velCar1 =< velCar2 && laps =< 15) {
        velCar1++;
        velCar2 += 3;
        laps++;
        Console.WriteLine("Car 1: " + velCar1 + " km/h");
        Console.WriteLine("Car 2: " + velCar2 + " km/h");

        if (velCar1 > velCar2) {
            Console.WriteLine("Car 1 wins the lap");
        } else if (velCar2 > velCar1) {
            Console.WriteLine("Car 2 wins the lap");
        }
    }



    int velCar1 = 200;
    int velCar2 = 180;
    int laps = 0;

    while (velCar1 <= velCar2 && laps < 15) {
        velCar1++;
        velCar2 += 3;
        laps++;

        Console.WriteLine("Lap " + laps);
        Console.WriteLine("Car 1: " + velCar1 + " km/h");
        Console.WriteLine("Car 2: " + velCar2 + " km/h");

        if (velCar1 > velCar2) {
            Console.WriteLine("Car 1 wins this lap!");
        } else if (velCar2 > velCar1) {
            Console.WriteLine("Car 2 wins this lap!");
        }
        Console.WriteLine();
    }

    if (laps == 15) {
        Console.WriteLine("Race ended: Max laps reached.");
    } else {
        Console.WriteLine("Race ended: Car 2's speed exceeded Car 1's.");
    }

    // Solved Exercise (14.1)
    
    int carro1 = 200, carro2 = 180, voltas = 15;

    for (int i = 0; i < 15; i++)
    {
        if (carro2 > carro1)
    {
        Console.WriteLine("O carro foi ultrapassado");
        break;
    } else {
        Console.WriteLine("Ainda não foi ultrapassado");
    }
        carro2 = carro2 + 3;
        carro1 = carro1 + 1;
    }


    // 02 (OK!)

    int grade1, grade2, grade3, grade4, grade5;

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Enter the grade: ");
        grade1 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("The first grade is: " + grade1);
        grade2 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("The second grade is: " + grade2);
        grade3 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("The third grade is: " + grade3);
        grade4 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("The fourd grade is: " + grade4);
        grade5 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("The five grade is: " + grade5);
        

        if (grade1 < 0 || grade1 > 100 || grade2 < 0 || grade2 > 100 || grade3 < 0 || grade3 > 100 || grade4 < 0 || grade4 > 100 || grade5 < 0 || grade5 > 100)
        {
            Console.WriteLine("Invalid grade");
        }

        if (grade1 + grade2 + grade3 + grade4 + grade5 > 300)
        {
            Console.WriteLine("Approved");
        } else {
            Console.WriteLine("Disapproved");
        }

      }

    // Solved Exercise (14.2)
    float n1 = -1, n2 = -1, n3 = -1, n4 = -1, n5 = -1, nf = 0;
    while (nf < 300)
    {
        while (n1 < 0 || n1 > 100)
        {
            Console.WriteLine("Digite a nota 1");
            n1 = Int16.Parse(Console.ReadLine());  
        }
        nf= nf+n1;
        while (n2 < 0 || n2 > 100)
        {
            Console.WriteLine("Digite a nota 2");
            n2 = Int16.Parse(Console.ReadLine());
        }
        nf = nf+n2;
        while (n3 < 0 || n3 > 100)
        {
            Console.WriteLine("Digite a nota 3");
            n3 = Int16.Parse(Console.ReadLine());
        }
        nf = nf+n3;
        if(nf >= 300){
            Console.WriteLine("Aprovado");
            break
        }
        while (n4 < 0 || n4 > 100)
        {
            Console.WriteLine("Digite a nota 4");
            n4 = Int16.Parse(Console.ReadLine());
        }
        nf = nf+n4;
        if(nf >= 300){
            Console.WriteLine("Aprovado");
            break
        }
        while (n5 < 0 || n5 > 100)
        {
            Console.WriteLine("Digite a nota 5");
            n5 = Int16.Parse(Console.ReadLine());
        }
        nf = nf+n5;
        if(nf >= 300){
            Console.WriteLine("Aprovado");
            break
        }
            Console.WriteLine("Reprovado");
            break;
        
    }

    // Class 15 - Functions
    void
    main

    {
    int a = 4, b = 5, c;
    c = Program.soma(a, b);

    writeSum(c);
    //Console.WriteLine("The sum is " + c);
    }

    static int soma(int x, int y)
    {
        return x + y;
    }

    static void writeSum(int c)
    {
        Console.WriteLine("The sum is " + c);
    }


    // Class 15 - Exercises
    // 01 (OK!)
using System;

    class Program {
    public static void Main (string[] args) {


        float side1, side2, side3, perimeter;

        Console.WriteLine("Enter side 1: ");
        side1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 2: ");
        side2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 3: ");
        side3 = float.Parse(Console.ReadLine());

        // Chama o método CalcPerimeter para calcular o perímetro
        perimeter = CalcPerimeter(side1, side2, side3);

        // Exibe o perímetro
        Console.WriteLine("The perimeter is: " + perimeter);
    }

        // Método para calcular o perímetro
    static float CalcPerimeter(float side1, float side2, float side3)
    {
        return side1 + side2 + side3;
    }
    
}
    
    }   
}