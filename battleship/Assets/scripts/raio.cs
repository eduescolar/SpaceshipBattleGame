using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raio : MonoBehaviour
{
    //public int DanoDoRaioLaser;
    public int dano_Causado;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            other.gameObject.GetComponent<inimigos>().DanoCausadoNoInimigo(dano_Causado);
            
        }

        if (other.gameObject.CompareTag("meteor"))
        {
            Destroy(other.gameObject);
        }
    }
}
