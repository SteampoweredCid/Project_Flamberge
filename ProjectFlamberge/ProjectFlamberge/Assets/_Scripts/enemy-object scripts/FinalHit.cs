using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalHit : MonoBehaviour
{
   	public GameObject Plane;
    public int health;
    public Light Light;
    public GameObject Fire;


    public void OnCollisionEnter(Collision other)
    {
    	//Light intense = getComponent<Light>.intensity;
        if (health!=0)
        {
            health--;
            Light.intensity=10;
            
        }

        if (health<=15)
        {
            Fire.SetActive(true);
        }
        //Light.intensity=0;
        if (health == 0)
        {
            SceneManager.LoadScene("End Game");
        }
        //Destroy(other.gameObject);
        //Destroy(gameObject);
    }

    public void OnCollisionExit(Collision other)
    {
    	Light.intensity=0;
    }
}
