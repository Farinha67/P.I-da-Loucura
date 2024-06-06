using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ControladorDePontuação
{
  
    private static int pontuacao;


    public static int Pontuacao
    {
        get
        {
            return pontuacao;
        }
        set
        {
            pontuacao = value;
            if (pontuacao < 0)
            {
                pontuacao = 0;
            }
            Debug.Log("Pontuação atualizada para: " + Pontuacao);
        }
    }
}
