using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float height;


    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - transform.forward * height;
    }
}
