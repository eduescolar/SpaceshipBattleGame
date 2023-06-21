using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class inimigos : MonoBehaviour
{

    public GameObject laserInimigo;
    public Transform localDeDisparo;

    public float tempoMaxEntreLasers;
    public float tempoAtualDosLasers;

    public bool inimigoAtirador;

    public float velocidadeInimigo;

    public int inimigoVidaMax;
    public int vidaAtualInimigo;

    public int pontosAseremDados;

    public int danoDoImpacto;

    public bool inimigoAtivo = true;

    void Start()
    {
        
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
        //movimentar o game object para esquerda
        transform.Translate(Vector3.left * velocidadeInimigo * Time.deltaTime);
    }

    public void Atirar()
    {
        tempoAtualDosLasers += Time.deltaTime;

        if (tempoAtualDosLasers >= tempoMaxEntreLasers)
        {

            
            Instantiate(laserInimigo, localDeDisparo.position, transform.rotation);

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

    private void OnTriggerEnter2D(Collider2D other) //DETECTOR DE COLISÃO DO ATAQUE
    {
        if (other.gameObject.CompareTag("Player")) //verificar se foi o player que colidiu
        {
            other.gameObject.GetComponent<playerVida>().Dano(danoDoImpacto); //ACESSA O GAMEOBJECT QUE COLIDIU; ACESSA O SCRIPT VIDA DO PLAYER E EM SEGUIDA ATIVA O METODO PARA DAR DANO 
            Destroy(this.gameObject);
        }

    }
   
}

