using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{

    public float velocidadedaNave;
    private Vector2 teclado;
    public Rigidbody2D origidbody;
    public GameObject bullet;
    public Transform disparo;
    public bool laser;
   
    void Start()
    {
        laser = false;
    }

    
    void Update()
    {
        MovimentoJogador();
        AtirarLaser();
        
    }

    private void MovimentoJogador()
    {
        teclado = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        origidbody.velocity = teclado.normalized * velocidadedaNave;
    }

    private void AtirarLaser()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (laser == false)
            {
                Instantiate(bullet, disparo.position, disparo.rotation);
            }
        }
    }
}
