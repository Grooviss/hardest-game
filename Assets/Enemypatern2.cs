using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypatern2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationspeed = 5f;
    public Transform target;
    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationspeed * Time.deltaTime);
       
        var distance = Vector3.Distance(transform.position, target.position);
        if (distance < 1f)
        {
            target.position = new Vector3(0, 0, 0);
        }
    }
}
