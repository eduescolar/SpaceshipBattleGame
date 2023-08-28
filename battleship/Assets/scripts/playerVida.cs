using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerVida : MonoBehaviour
{
    public Slider lifeBar;
    public Slider shieldBar;
    public int vidaMax;
    public int vidaAtual;
    public bool haEscudo;
    public GameObject escudoDoPlayer;
    public int escudoVidaMax;
    public int escudoVidaAtual;
    


    void Start()
    {
        vidaAtual = vidaMax;

        lifeBar.maxValue = vidaMax;

        lifeBar.value = vidaAtual;

        shieldBar.maxValue = escudoVidaMax;

        //shieldBar.value = escudoVidaAtual;
        
        escudoDoPlayer.SetActive(true);
        
        escudoVidaAtual = escudoVidaMax;
    }
    
    void Update()
    {
        
    }

    public void EscudoActive(int escudoExtra)
    {
        shieldBar.value = escudoVidaAtual;
        escudoDoPlayer.SetActive(true);
        haEscudo = true;
        if (escudoVidaAtual + escudoExtra <= escudoVidaMax)
        {
            escudoVidaAtual += escudoExtra;
        }
        else
        {
            escudoVidaAtual = escudoVidaMax;
        }

        shieldBar.value = escudoVidaAtual;


    }

    public void PowerUpVida(int vidaextra)
    {
        if (vidaAtual + vidaextra <= vidaMax)
        {
            vidaAtual += vidaextra; 
        }
        else
        {
            vidaAtual = vidaMax;
        }

        lifeBar.value = vidaAtual;
    }

    public void Dano(int danoAReceber) 
    {
        if (haEscudo == false)
        {
            vidaAtual -= danoAReceber;
                    
            lifeBar.value = vidaAtual;
                    
            if (vidaAtual <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("GAME OVER");
            }
        }
        else
        {
            escudoVidaAtual -= danoAReceber;
            shieldBar.value = escudoVidaAtual;
            if (escudoVidaAtual <= 0)
            {
                escudoDoPlayer.SetActive(false);
                haEscudo = false;
            }
        }
    }
    



}
