using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string Scene;
    void Start()
    {
        //anim = Camera.GetComponent<Animator>();
        Setlevel(Scene);
    }

    void Setlevel(string scene)
    {
        //string scene = "City";Debug.Log(PlayerPrefs.HasKey(scene));
        PlayerPrefs.SetString("sceneName", scene);

        PlayerPrefs.Save();
        
    }
}
