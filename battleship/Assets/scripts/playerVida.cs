using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerVida : MonoBehaviour
{
    public Slider lifeBar;
    public int vidaMax;
    public int vidaAtual;
    


    void Start()
    {
        vidaAtual = vidaMax;

        lifeBar.maxValue = vidaMax;

        lifeBar.value = vidaAtual;
    }
    
    void Update()
    {
        
    }

    public void Dano(int danoAReceber) 
    {
        vidaAtual -= danoAReceber;
        
        lifeBar.value = vidaAtual;
        
        if (vidaAtual <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("GAME OVER");
        }
    }



}
