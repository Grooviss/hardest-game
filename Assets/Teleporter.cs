using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
    
{
    public string nextlevelName;
    // Start is called before the first frame update
      
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            SceneManager.LoadScene(nextlevelName);
        }
        
    }
}
