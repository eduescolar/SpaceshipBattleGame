using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{
    public GameObject[] objetosPraraSpawn;
    public Transform[] pontosdeSpawn;

    public float tempoEntreSpawns;
    public float tempoAtualdosSpawns;
    void Start()
    {
        tempoAtualdosSpawns = tempoEntreSpawns;
    }

    
    void Update()
    {
        tempoAtualdosSpawns -= Time.deltaTime;
        if (tempoAtualdosSpawns <= 0)
        {
            invocarObjetos();
        }
    }

    private void invocarObjetos()
    {
        int ramdomObject = Random.Range(0, objetosPraraSpawn.Length);
        int pontoAleatorio = Random.Range(0, pontosdeSpawn.Length);

        Instantiate(objetosPraraSpawn[ramdomObject], pontosdeSpawn[pontoAleatorio].position, Quaternion.Euler(0f, 0f, 0f));
        tempoAtualdosSpawns = tempoEntreSpawns;
        
    }
}
