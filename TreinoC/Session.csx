using System;
using System.Collections.Generic;


public class Pessoa
{
    public string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public string Cidade { get; set; }
}

public class TreinoFocadoC
{
    public int Trimestre (DateTime data)
    {
        int Resultado = 0;

        if (data.Month >= 1 && data.Month <= 3)
        
            Resultado = 1;
        

        else if (data.Month > 3 && data.Month <= 6)
        
            Resultado = 2;
        

        else if (data.Month > 6 && data.Month <= 9)
        
            Resultado = 3;
        

        else if(data.Month > 9 && data.Month <= 12)
        
            Resultado = 4;
        

        return Resultado;
    }

    public string Mes (int mes)
    {
        string Resultado = string.Empty;

        if (mes == 1)
        
            Resultado = $"Janeiro";
        

        else if (mes == 2)
        
            Resultado = $"Fevereiro";
        

        else if (mes == 3)
        
            Resultado = $"Março";
        

        else if (mes == 4)
        
            Resultado = $"Abril";
        

        else if (mes == 5)
        
            Resultado = $"Maio";
        

        else if (mes == 6)
        
            Resultado = $"Junho";
        

        else if (mes == 7)
        
            Resultado = $"Julho";
        

        else if (mes == 8)
        
            Resultado = $"Agosto";
        

        else if (mes == 9)
        
            Resultado = $"Setembro";
        

        else if (mes == 10)
        
            Resultado = $"Outubro";
        

        else if (mes == 11)
        
            Resultado = $"Novembro";
        

        else if (mes == 12)
        
            Resultado = $"Dezembro";
        

        else if (mes > 12)
        
            Resultado = $"Você não escolheu um mês valido";
        

        return Resultado;
    }

    public string PeriodoDia(DateTime data)
    {
        string Resultado = string.Empty;

        if (data.Hour >= 6 && data.Hour < 12)
        
            Resultado = $"Manhã";
        

        else if (data.Hour >= 12 && data.Hour < 18)
        
            Resultado = $"Tarde";
        

        else if (data.Hour >= 18 || data.Hour < 0)
        
            Resultado = $"Noite";
        

        else if (data.Hour >= 0 && data.Hour < 6)
        
            Resultado = $"Madrugada";
        

        return Resultado;
    }

    public double DiasVida(DateTime nascimento)
    {
        TimeSpan Dias = DateTime.Now - nascimento;
        return Dias.Days;
    }

    public string QualSigno(DateTime nascimento)
    {
        string Resultado = string.Empty;

        if (nascimento.Month == 3 && nascimento.Day >= 21 ||
            nascimento.Month == 4 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Áries";
        }

        else if (nascimento.Month == 4 && nascimento.Day >= 21 ||
            nascimento.Month == 5 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Touro";
        }

        else if (nascimento.Month == 5 && nascimento.Day >= 21 ||
            nascimento.Month == 6 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Gêmeos";
        }

         else if (nascimento.Month == 6 && nascimento.Day >= 21 ||
            nascimento.Month == 7 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Câncer";
        }

         else if (nascimento.Month == 7 && nascimento.Day >= 23 ||
            nascimento.Month == 8 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Leão";
        }

         else if (nascimento.Month == 8 && nascimento.Day >= 23 ||
            nascimento.Month == 9 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Virgem";
        }

        else if (nascimento.Month == 9 && nascimento.Day >= 23 ||
            nascimento.Month == 10 && nascimento.Day <= 22)
        {
            Resultado = $"Seu signo é Libra";
        }

        else if (nascimento.Month == 10 && nascimento.Day >= 23 ||
            nascimento.Month == 11 && nascimento.Day <= 21)
        {
            Resultado = $"Seu signo é Escorpião";
        }

        else if (nascimento.Month == 11 && nascimento.Day >= 22 ||
            nascimento.Month == 12 && nascimento.Day <= 21)
        {
            Resultado = $"Seu signo é Sagitário";
        }

        else if (nascimento.Month == 12 && nascimento.Day >= 22 ||
            nascimento.Month == 1 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Capricórnio";
        }

        else if (nascimento.Month == 1 && nascimento.Day >= 21 ||
            nascimento.Month == 2 && nascimento.Day <= 18)
        {
            Resultado = $"Seu signo é Aquário";
        }

        else if (nascimento.Month == 2 && nascimento.Day >= 19 ||
            nascimento.Month == 3 && nascimento.Day <= 20)
        {
            Resultado = $"Seu signo é Peixes";
        }

        return Resultado;
    }

    public String DataPorExtenso(Pessoa pessoa)
    {
        string Resultado = string.Empty;
        Resultado = $"{pessoa.Nome} você nasceu há {DiasVida(pessoa.Nascimento)} dias, em uma {PeriodoDia(pessoa.Nascimento)} do dia {pessoa.Nascimento.Day} de {Mes(pessoa.Nascimento.Month)} ({Trimestre(pessoa.Nascimento)} Trimestre) de {pessoa.Nascimento.Year}. {QualSigno(pessoa.Nascimento)}.";
        return Resultado;
    }
}

TreinoFocadoC treino = new TreinoFocadoC();

Pessoa pessoa = new Pessoa();
pessoa.Nome = $"Luigi";
pessoa.Nascimento = new DateTime(2004, 04, 26);

string x = treino.DataPorExtenso(pessoa);
Console.WriteLine(x);