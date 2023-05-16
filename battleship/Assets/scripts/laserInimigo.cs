using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserInimigo : MonoBehaviour
{
    public float laserVelocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LaserMovimento();
    }
    private void LaserMovimento()
    {
        transform.Translate(Vector3.left * laserVelocidade * Time.deltaTime);
    }
}
