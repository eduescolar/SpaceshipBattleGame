using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoro : MonoBehaviour
{

    public float velocidadeDoMeteoro;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
