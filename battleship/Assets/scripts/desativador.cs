using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class desativador : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
        }
        
        
        //if (other.gameObject.CompareTag("bullet"))
       // {
         //   Destroy(other.gameObject);
        //}
        //VERIFICA SE O OBJETO É UM INIMIGO OU PROJÉTIL. SE FOR, OS DESTRÓI AO SAIR DO CAMPO DE VISÃO DO JOGADOR.
    }
}
