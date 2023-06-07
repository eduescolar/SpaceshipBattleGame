using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontuacaoAtual;
    public static GameManager instance;
    public Text pontuacao;

    private void Awake()
    {
        instance = this;
    }

    
    void Start()
    {
        pontuacaoAtual = 0;
        pontuacao.text = "PONTUAÇÃO: " + pontuacaoAtual;
    }

    
    void Update()
    {
        
    }

    public void AumentoDePontuacao(int pontosAganhar)
    {
        pontuacaoAtual += pontosAganhar;
        pontuacao.text = "PONTUAÇÃO: " + pontuacaoAtual;
    }
    
    
    
}
