using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    
    
    public float RotationSpeed = 90;
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
