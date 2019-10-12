using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Onhitload : MonoBehaviour
{
    public string SceneToLoad;
    //public Scene Scene;

    public void OnTriggerEnter(Collider other)
    {       
        if(other.tag == "Player")
        {
           
            Debug.Log("Loading Scene");
            SceneManager.LoadScene(SceneToLoad);
    

        }
    }
    
    
}
