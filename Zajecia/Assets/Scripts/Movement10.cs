using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement10 : MonoBehaviour
{
    [SerializeField] float VectorX;
    [SerializeField] float VectorY = 0;
    [SerializeField] float VectorZ;
    [SerializeField] float speed = 0 ;

    void Start()
    {
        
    }

    void Update()
    {
        VectorX = Input.GetAxis("Horizontal"); 
        VectorZ = Input.GetAxis("Vertical"); 
        transform.Translate(VectorX*Time.deltaTime*speed,VectorY * Time.deltaTime * speed, VectorZ * Time.deltaTime * speed);

        
    }
}
