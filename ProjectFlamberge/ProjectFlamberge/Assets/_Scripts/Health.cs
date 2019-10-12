using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    public GameObject danger;
    //public GameObject HealthPip3;


    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<ShipController>().health==4){
        	//Debug.Log("Full");
        }
        if(player.GetComponent<ShipController>().health==3){
        	try{
        	 GameObject.Find("HealthPip3").SetActive(false);
        	 //Debug.Log("Found");
        	}
        	catch{
        		//Debug.Log("Lost");
        	}
        }
        if(player.GetComponent<ShipController>().health==2){
        	 try{
        	 GameObject.Find("HealthPip2").SetActive(false);
        	 //Debug.Log("Found");
        	}
        	catch{}
        }
        if(player.GetComponent<ShipController>().health==1){
        	 try{
        	 	//Debug.Log("Before Danger!");
        	 GameObject.Find("HealthPip1").SetActive(false);
        	 //Debug.Log("Danger!");
        	 danger.SetActive(true);
        	 	//Debug.Log("Danger!");
        	}
        	catch{
        		
        	}
        }
    }
}
