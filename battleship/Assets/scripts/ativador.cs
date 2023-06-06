using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativador : MonoBehaviour
{
    private inimigos _Inimigos;

    private void Start()
    {
        _Inimigos = GameObject.Find("cruzador").GetComponent<inimigos>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            //other.gameObject.GetComponent<inimigos>().AtivarInimigo();
            _Inimigos.AtivarInimigo();
        }
    }
    
}
