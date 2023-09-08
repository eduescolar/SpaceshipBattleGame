using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RaioLaser : MonoBehaviour
{
    public GameObject raio;
    public Slider energiaDoRaio;
    private float valorMaxRaio = 45;
    private float valorAtualRaio;
    void Start()
    {
        valorAtualRaio = valorMaxRaio;
        energiaDoRaio.maxValue = valorMaxRaio;
        energiaDoRaio.value = valorAtualRaio;
    }

    // Update is called once per frame
    void Update()
    {
        AtivarRaioLaser();
    }

    private void AtivarRaioLaser()
    {
        if (Input.GetButton("Fire2") && valorAtualRaio > 0)
        {
            raio.SetActive(true);
            valorAtualRaio -= 0.1F;
            energiaDoRaio.value = (valorAtualRaio);
        }
        else
        {
            raio.SetActive(false);
        }
    }

    public void PowerUpRaio(int energiaExtra)
    {
        energiaDoRaio.enabled = true;
        raio.SetActive(true);
        energiaDoRaio.maxValue = valorMaxRaio;
        
        if (valorAtualRaio + energiaExtra <= valorMaxRaio)
        {
            valorAtualRaio += energiaExtra;
        }
        else
        {
            valorAtualRaio = valorMaxRaio;
        }

        energiaDoRaio.value = valorAtualRaio;
    }
}
