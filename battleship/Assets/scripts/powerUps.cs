using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class powerUps : MonoBehaviour
{

    public bool powerUpEscudo;

    public bool powerUpVida;

    public bool powerUpRaio;


    public int vidaExtra;
    public int escudoExtra;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (powerUpEscudo == true)
            {
                other.gameObject.GetComponent<playerVida>().EscudoActive(escudoExtra);
            }
            if(powerUpRaio == true)
            {
                
            }
            if (powerUpVida == true)
            {
                other.gameObject.GetComponent<playerVida>().PowerUpVida(vidaExtra);
            }
            Destroy(this.gameObject);
        }
        
    }
}
