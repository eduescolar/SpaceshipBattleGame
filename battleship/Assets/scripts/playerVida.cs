using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerVida : MonoBehaviour
{
    public int vidaMax;
    public int vidaAtual;
    


    void Start()
    {
        vidaAtual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dano(int danoAReceber) 
    {
        vidaAtual -= danoAReceber;
        if (vidaAtual <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
    
    
    
}
