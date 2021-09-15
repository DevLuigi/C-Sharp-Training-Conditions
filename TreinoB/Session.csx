using System;
using System.Collections.Generic;


public class PecaDomino 
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
}

public class Semaforo
{
    public bool LuzVermelhaAcesa { get; set; }
    public bool LuzAmarelaAcesa { get; set; }
    public bool LuzVerdeAcesa { get; set; }
}

public class Recuperacao
{
    public string Email { get; set; }
    public string Telefone { get; set; }
}


public class TreinoFocadoB
{
    public bool   CorPrimaria (string cor)
    {
       bool Primaria = cor == $"Amarela" ||cor == $"Azul" || cor == $"Vermelho"
                     ? true  
                     : false;
       return Primaria;              
    }

    public string CombinacaoCorPrimaria (string cor1, string cor2)
    {
        string Resultado = string.Empty;

        if(cor1 == $"Amarelo"  && cor2 == $"Vermelho" ||
           cor1 == $"Vermelho" && cor2 == $"Amarelo")
        
            Resultado = $"Sua nova cor é a Laranja!!";
        
        else if (cor1 == $"Amarelo" && cor2 == $"Azul" ||
                 cor1 == $"Azul"    && cor2 == $"Amarelo")
        
            Resultado = $"Sua nova cor é a Verde!!";
        
        else if (cor1 == $"Vermelho" && cor2 == $"Azul" ||
                 cor1 == $"Azul"     && cor2 == $"Vermelho")
        
            Resultado = $"Sua nova cor é a Roxo!!";

        else
        
            Resultado = $"Você não colocou duas cores primarias, repasse os parâmetros.";    
          
        return Resultado;  
    }

    public string PrimeiroNome(string nome)
    {
        string Resultado = nome.Contains($" ") 
                           ?  nome.Substring(0, nome.IndexOf($" "))
                           :  Resultado = nome;
        return Resultado;
    }

    public bool   DobreDomino(PecaDomino peca)
    {
        bool Dobre = peca.LadoA == peca.LadoB
                                 ? true
                                 : false;
        return Dobre;                 
    }

    public bool   JogadaValida(PecaDomino peca1, PecaDomino peca2)
    {
        bool Resultado;

        if (peca1.LadoA == peca2.LadoA ||
            peca1.LadoA == peca2.LadoB ||
            peca1.LadoB == peca2.LadoA ||
            peca1.LadoB == peca2.LadoB)
        
            Resultado = true;
        
        else
        
            Resultado = false;
        
        return Resultado;
    }

    public string RecuperacaoSenha(Recuperacao rec)
    {
        string CorteEmail  = rec.Email.Substring(rec.Email.LastIndexOf("@"));
        string Dominio = CorteEmail.Substring(1, CorteEmail.IndexOf("."));

        string CorteTelefone = rec.Telefone.Substring(rec.Telefone.LastIndexOf("-"));
        string Numeros = CorteTelefone.Substring(2);

        string Mensagem = $"Você receberá um e-mail do {Dominio} para resetar a senha. Um código também foi enviado para o número {Numeros}.";
        return Mensagem;
    }

    public Semaforo IniciarSemaforo()
    {
        Semaforo s = new Semaforo();

        s.LuzVermelhaAcesa = true;
        s.LuzAmarelaAcesa = false;
        s.LuzVerdeAcesa = false;

        return s;
    }

    public Semaforo ProximoSinal (Semaforo s)
    {
        if (s.LuzVermelhaAcesa)
        {
            s.LuzVermelhaAcesa = false;
            s.LuzAmarelaAcesa  = true;
            s.LuzVerdeAcesa    = false;
        }
        else if (s.LuzAmarelaAcesa)
        {
            s.LuzVermelhaAcesa = false;
            s.LuzAmarelaAcesa  = false;
            s.LuzVerdeAcesa    = true;
        }
        else if (s.LuzVerdeAcesa)
        {
            s.LuzVermelhaAcesa = true;
            s.LuzAmarelaAcesa  = false;
            s.LuzVerdeAcesa    = false;
        }

        return s;
    }   
}