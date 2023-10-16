using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class laser : MonoBehaviour
{
    
    
    public float laserVelocidade;

    public int danoCausado;
    public int dano_causado;
    void Start()
    {
        
    }
    
    
    void Update()
    {
        MovimentoDoLaser();
    }

    private void MovimentoDoLaser()
    {
        transform.Translate(Vector3.up * laserVelocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            //other.gameObject.GetComponent<inimigos>().DanoCausadoNoInimigo(danoCausado);
            other.gameObject.GetComponent<navemae>().DanoSofrido(dano_causado);
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("meteor"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    
}
