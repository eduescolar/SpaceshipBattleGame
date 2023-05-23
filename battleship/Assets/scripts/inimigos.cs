using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class inimigos : MonoBehaviour
{
    
    public GameObject laserInimigoo;
    public Transform localDeDisparo;
    
    public float tempoMaxEntreLasers;
    public float tempoAtualDosLasers;
    
    public bool inimigoAtirador;
    
    public float velocidadeInimigo;

    public int inimigoVidaMax;
    public int vidaAtualInimigo;

    public int pontosAseremDados;

    public bool inimigoAtivo;
    void Start()
    {
        inimigoAtivo = false;
        vidaAtualInimigo = inimigoVidaMax;
    }

   
    void Update()
    { 
        MovimentarInimigo();
        
        if (inimigoAtirador == true && inimigoAtivo == true)
        {
            Atirar();
        }
        
    }

    public void AtivarInimigo()
    {
        inimigoAtivo = true;
    }
    

    private void MovimentarInimigo()
    {
        //movimentar o game object em alguma direção
        transform.Translate(Vector3.left * velocidadeInimigo * Time.deltaTime);
    }

    private void Atirar()
    {
        tempoAtualDosLasers += Time.deltaTime;
        if (tempoAtualDosLasers >= tempoMaxEntreLasers)
        {
            Instantiate(laserInimigoo, localDeDisparo.position, Quaternion.Euler(0f, 0f, 0f));
            
            tempoAtualDosLasers = 0;
            
            
        }
        
    }

    public void DanoCausadoNoInimigo(int danoRecebido)
    {
        vidaAtualInimigo -= danoRecebido;

        if (vidaAtualInimigo <= 0)
        {
            GameManager.instance.AumentoDePontuacao(pontosAseremDados);
            Destroy(this.gameObject);
        }
    }
}

