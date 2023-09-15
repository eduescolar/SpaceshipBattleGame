using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class navemae : MonoBehaviour
{
    public Transform Ponto_de_Disparo_1;
    public Transform Ponto_de_Disparo_2;
    public GameObject mae_bullet;
    public int velocidade_mae;

    public float tempo_Atual_Dos_bullets;
    public float tempo_entre_bullets;
    
    public int mae_vida_Max;
    public int mae_vida_atual;
    public Slider barra_de_vida_da_mamae;

    void Start()
    {
        mae_vida_atual = mae_vida_Max;
        barra_de_vida_da_mamae.maxValue = mae_vida_Max;
        
        barra_de_vida_da_mamae.value = mae_vida_atual;
        
    } 

    // Update is called once per frame
    void Update()
    {
        Ataque_basico();

        if (transform.position.x > 14)
        {
            Mae_movimento();
        }
    }

    public void Ataque_basico()
    {
        tempo_Atual_Dos_bullets += Time.deltaTime;

        if (tempo_Atual_Dos_bullets >= tempo_entre_bullets)
        {
            Instantiate(mae_bullet, Ponto_de_Disparo_1.position, transform.rotation);
            Instantiate(mae_bullet, Ponto_de_Disparo_2.position, transform.rotation);
            tempo_Atual_Dos_bullets = 0;
        }
    }

    public void Mae_movimento()
    {
        transform.Translate(Vector3.left * velocidade_mae * Time.deltaTime);
    }

    public void DanoSofrido(int dano_sofrido)
    {
        mae_vida_atual -= dano_sofrido;

        if (mae_vida_atual <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
}
