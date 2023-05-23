using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativador : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            other.gameObject.GetComponent<inimigos>().AtivarInimigo();
        }
    }
    
}
