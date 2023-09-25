using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacaoAtual;
    public GameObject painelDeGameover;
    public Text textoDeGameover;
    public Text textoDeHighScore;
    public Text textoDePontuacaoFinal;
    public static GameManager instance;
    public Text pontuacao;

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        Time.timeScale = 1f;
        pontuacaoAtual = 0;
        pontuacao.text = "SCORE: " + pontuacaoAtual;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Quit();
    }
    
    public void Quit()
    {
        Application.Quit();
    }

    public void AumentoDePontuacao(int pontosAganhar)
    {
        pontuacaoAtual += pontosAganhar;
        pontuacao.text = "SCORE: " + pontuacaoAtual;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        painelDeGameover.SetActive(true);
        textoDePontuacaoFinal.text = "SCORE: " + pontuacaoAtual;

        if (pontuacaoAtual > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", pontuacaoAtual);
        }

        textoDeHighScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
    }
    void AtivarNaveMae()
    {
        
    }

}
