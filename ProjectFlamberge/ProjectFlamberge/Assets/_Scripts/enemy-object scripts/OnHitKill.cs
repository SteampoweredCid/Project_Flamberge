using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnHitKill : MonoBehaviour
{

    //public string SceneToLoad;
    
    
    public void OnTriggerEnter(Collider other)
    {
    
            if (other.tag == "Player" && other.GetComponent<ShipController>().health != 0)
            {
                if (other.GetComponent<ShipController>().playerTime < Time.time)
                {
                    other.GetComponent<ShipController>().health--;
                    other.GetComponent<ShipController>().InvTime();
                    Debug.Log("Owch!");
                }
            }
            if (other.tag == "Player" && other.GetComponent<ShipController>().health <= 0)
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
                //Debug.Log("hit");
                //Debug.Log("Loading Scene");
                SceneManager.LoadScene("GameOver");


            
        }
        if(other.tag == "Bullet")
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
           
            Destroy(gameObject);
            Debug.Log("hit");
        }
        if(other.tag == "Enemy")
        {
            Debug.Log("Safe");
        }
        //Debug.Log("pass");
    }
    

    //public void OnCollisionEnter(Collision other)
    //{       
        //Destroy(other.gameObject);
        //Destroy(gameObject);
        //Debug.Log("OutrightKill");
    //}
}
