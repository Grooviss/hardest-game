using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
    
{
    public float speed;
    public Vector3 spawnpoint;
    private void Start()
    {
        spawnpoint = transform.position;
    }
    // Start is called before the first frame update
    void Update()
    {
        Vector3 movedirection = new Vector3();
        movedirection.x = Input.GetAxis("Horizontal");
        movedirection.z = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = movedirection * speed;
        transform.forward = movedirection;



        /*f
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += new Vector3(x: speed, y: 0, z: 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += new Vector3(x: 0, y: 0, z: speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += new Vector3(x: -speed, y: 0, z: 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += new Vector3(x: 0, y: 0, z: -speed) * Time.deltaTime;
        }*/

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            Die();
        }
    }

    public void Die()
    {
        var sceneNow = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneNow);
    }
    // Update is called once per frame

}
