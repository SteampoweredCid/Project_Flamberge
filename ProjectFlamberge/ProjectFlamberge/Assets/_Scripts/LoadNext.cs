using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadNext : MonoBehaviour
{
    public string SceneToLoad;


    void OnMouseDown()
    {
        Debug.Log("Loading Scene");
        SceneManager.LoadScene("Level1");
    }

    void Update()
    {
        if (Input.GetButton("Submit"))
        {
            Debug.Log("Loading Scene");
            SceneManager.LoadScene("Level1");
        }
    }
}