using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnterStart : MonoBehaviour
{
    public string SceneToLoad;
    private string GottenScene;

	void Getlevel(string scene)
	{
		string sceneName = "sceneName";
		//Debug.Log(PlayerPrefs.HasKey(sceneName));
  		GottenScene = PlayerPrefs.GetString(sceneName);
  		//Debug.Log(GottenScene + " loaded");
  		//PlayerPrefs.Save();
  		// if (scene!="Tunnel" || scene!="level1v2" || scene!="City"){
  		// 	PlayerPrefs.SetString("Tunnel", scene);
  		// 	SceneToLoad = PlayerPrefs.GetString(scene);
  		// }
	}


    void Update(){
    	Getlevel(GottenScene);
    	//Debug.Log(GottenScene);
    	if (Input.GetKeyDown("return") || Input.GetKey("joystick button 7")){
    		// if(GottenScene==null){
    		// 	SceneManager.LoadScene(SceneToLoad);
    		// }
    		//Debug.Log("Loading Scene");
        	SceneManager.LoadScene(GottenScene);
    	}
       
    }
}
