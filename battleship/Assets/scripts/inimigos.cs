using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class inimigos : MonoBehaviour
{
    public float velocidadeDoInimigo;
    public GameObject laserInimigoo;
    public Transform localDeDisparo;
    public float tempoEntreLasers;
    public float tempoAtualDosLasers;
    public bool inimigoAtirador;
    void Start()
    {
        
    }

   
    void Update()
    {
        MovimentarInimigo();
        if (inimigoAtirador == true)
        {
            Atirar();
        }
        
    }

    private void MovimentarInimigo()
    {
        //movimentar o game object em alguma direção
        transform.Translate(Vector3.left * velocidadeDoInimigo * Time.deltaTime);
    }

    private void Atirar()
    {
        tempoEntreLasers -= Time.deltaTime;
        if (tempoAtualDosLasers <= 0)
        {
            Instantiate(laserInimigoo, localDeDisparo.position, Quaternion.Euler(0f, 0f, 0f));
            tempoAtualDosLasers = tempoEntreLasers;
        }
    }
}
