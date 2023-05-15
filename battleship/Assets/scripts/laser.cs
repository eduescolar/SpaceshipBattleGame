using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float laserVelocidade;
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
}
