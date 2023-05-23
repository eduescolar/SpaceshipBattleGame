using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float velocidade;
    void Update()
    {
        CenarioMovimento();
    }

    private void CenarioMovimento()
    {
        Vector2 deslocamento = new Vector2(Time.time * velocidade, 0f);

        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;
    }
}
