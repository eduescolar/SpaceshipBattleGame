using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{
    public GameObject[] objectsForSpawn;
    public Transform[] pontosdeSpawn;

    public float tempoEntreSpawns;
    public float tempoAtualdosSpawns;

    public float tempoMaxEntreSpawns;
    //public float tempoAtualDeSpawns;
    void Start()
    {
        tempoAtualdosSpawns = tempoMaxEntreSpawns;
    }

    
    void Update()
    {
        tempoAtualdosSpawns -= Time.deltaTime;

        if (tempoAtualdosSpawns <= 0)
        {
            Spawn();
        }
    }

    private void Spawn()
    {   
        int randomObject = Random.Range(0, objectsForSpawn.Length);

        int pontoAleatório = Random.Range(0, pontosdeSpawn.Length);

        Instantiate(objectsForSpawn[randomObject], pontosdeSpawn[pontoAleatório].position, Quaternion.Euler(0f, 0f, 0f));
        tempoAtualdosSpawns = tempoMaxEntreSpawns;
    }
}
