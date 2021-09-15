using System;
using System.Collections.Generic;

public class Calculo
{
    public double Valor1 { get; set; }
    public double Valor2 { get; set; }
    public string Operacao { get; set; }
}

public class Triangulo
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }
}

public class Pessoa
{
    public string Nome { get; set; }
    public double Altura { get; set; }
     public double Peso { get; set; }
}

public class Notas
{
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
}

public class TreinoFocadoA
{
    public double Calculadora(Calculo calculo)
    {
       double Resultado = 0;
       if(calculo.Operacao == $"soma")
       
           Resultado = calculo.Valor1 + calculo.Valor2;
        

       else if (calculo.Operacao == $"subtração")
       
           Resultado = calculo.Valor1 - calculo.Valor2;
       

       else if (calculo.Operacao == $"multiplicação")
       
           Resultado = calculo.Valor1 * calculo.Valor2;
       
       
        else if (calculo.Operacao == $"divisão")   
       
           Resultado = calculo.Valor1 / calculo.Valor2;

        else if (calculo.Operacao == $"potência")   
       
           Resultado = Math.Pow(calculo.Valor1, calculo.Valor2);   
        
        return Resultado;
    }

    public string Termometro(double grau)
    {
        string Situacao = string.Empty;
        if( grau >= 37.6 && grau <= 39.5)
        
            Situacao = $"Você está com Febre";
        

        else if( grau >= 39.6 && grau <= 41)
        
            Situacao = $"Você está com Febre Alta";
        
        else if( grau <= 35)
        
            Situacao = $"Você está com Hipotermia";

        else if( grau >= 36 && grau <= 37.5)
        
            Situacao = $"Você está Normal"; 

        return Situacao;    
    } 

    public string LucroOuPrejuizo(double Gastos, double Lucros)
    {
        string Situacao = Lucros - Gastos >= 0 
                            ? $"Muito bem, você está R${Lucros - Gastos} positivo."
                            : $"Poxa, você ficou R${Math.Abs(Lucros - Gastos)} negativo.";
        return Situacao;
    }

    public double ArredondarMeioEmMeio(double nota)
    {
        double notaInteira = Math.Truncate(nota);
        double nota1 =  Math.Round(nota - notaInteira, 2);

        if( nota1 >= 0.00 && nota1 <= 0.25)
        
           nota1 = Math.Floor(nota); 

        else if ( nota1 >= 0.26 && nota1 <= 0.74)
        
           nota1 = Math.Floor(nota) + 0.50;
        
        else if ( nota1 >= 0.75 && nota1 <= 0.99)
        
           nota1 = Math.Ceiling(nota);
        
        return nota1;
    }

    public string Passou(Notas notas)
    {
        string  Média = (notas.Nota1 + notas.Nota2 + notas.Nota3) / 3 > 5
                            ? $"Passou"
                            : $"Recuperacao";
        return Média;                    
    }

    public string Passou(Notas notas, int faltas)
    {
       double  Média = (notas.Nota1 + notas.Nota2 + notas.Nota3) / 3;
       string Resultado = string.Empty;

       if(Média >= 5 && faltas < 25)
       
           Resultado = $"Parabéns você passou!!!";
       
       else
       {
           if(faltas > 25 && Média >= 5)
           
               Resultado = $"Recuperação por Falta";
           
           else if(Média < 5 && faltas < 25)
           
               Resultado = $"Recuperação por Nota";
           
           else if(Média < 5 && faltas >= 25)
           
               Resultado = $"Recuperação por Nota e Falta";
           
       }
       return Resultado;
    }

    public string TipoTriangulo(Triangulo triangulo)
    {
        string Resultado = string.Empty; 

        if (triangulo.LadoA == triangulo.LadoB && triangulo.LadoA == triangulo.LadoC)
        {
            Resultado = $"Equilátero";
        }

        else if (triangulo.LadoA == triangulo.LadoB && 
                 triangulo.LadoA != triangulo.LadoC ||
                 triangulo.LadoA != triangulo.LadoB && 
                 triangulo.LadoA == triangulo.LadoC ||
                 triangulo.LadoB == triangulo.LadoC && 
                 triangulo.LadoB != triangulo.LadoA)
        {
            Resultado = $"Isósceles";
        }

        else if (triangulo.LadoA != triangulo.LadoB &&
                 triangulo.LadoA != triangulo.LadoC &&
                 triangulo.LadoB != triangulo.LadoC)
        {
            Resultado = $"Escaleno";
        }

        return Resultado;
    }

    public string IMC(Pessoa pessoa)
    {
        double IMC = pessoa.Peso / Math.Pow(pessoa.Altura, 2);
        string Resultado = string.Empty;

        if(IMC <= 18.5)
        {
            Resultado = $"{pessoa.Nome} você está Abaixo do Peso";
        }

        else if(IMC >= 18.5 && IMC <= 24.9)
        {
            Resultado = $"{pessoa.Nome} você está Peso Normal";
        }

        else if(IMC >= 25 && IMC <= 29.9)
        {
            Resultado = $"{pessoa.Nome} você está Sobrepeso";
        }
        return Resultado;
    } 
}