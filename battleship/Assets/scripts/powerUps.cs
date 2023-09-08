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
    public int energiaExtra;
    public int energiaDoRaio;

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
                other.gameObject.GetComponent<RaioLaser>().PowerUpRaio(energiaExtra);
            }
            if (powerUpVida == true)
            {
                other.gameObject.GetComponent<playerVida>().PowerUpVida(vidaExtra);
            }
            Destroy(this.gameObject);
        }
        
    }
}
