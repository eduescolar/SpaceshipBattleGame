using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class meteoro : MonoBehaviour
{
    
    public float velocidadeDoMeteoro;
    

    
    void Update()
    {
        MovimentarInimigo();
    }

    private void MovimentarInimigo()
    {
        //movimentar o game object para esquerda
        transform.Translate(Vector3.left * velocidadeDoMeteoro * Time.deltaTime);
    }
    
}


