using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float laserVelocidade;

    public int danoCausado;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoDoLaser();
    }

    private void MovimentoDoLaser()
    {
        transform.Translate(Vector3.up * laserVelocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D inimigo)
    {
        if (inimigo.gameObject.CompareTag("enemy"))
        {
            inimigo.gameObject.GetComponent<inimigos>().DanoCausadoNoInimigo(danoCausado);
            Destroy(this.gameObject);
        }
    }
}
