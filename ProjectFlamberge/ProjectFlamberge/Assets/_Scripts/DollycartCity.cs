using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;


public class DollycartWaypointscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //get speed from cinemachine dolly cart and modify at certain waypoints.
        // Also queue camera tilts at other serialized waypoints.
    }

    // Update is called once per frame

    private float PP;
    private float Spd;
    public CinemachineDollyCart dolly;
    void Update()
    {
    	PP = dolly.GetComponent<CinemachineDollyCart>().m_Position;
    	//Debug.Log(PP);
    	// Spd = dolly.GetComponent<CinemachineDollyCart>().m_Speed;
    	// if(PP>=600){
    	// 	dolly.GetComponent<CinemachineDollyCart>().m_Speed = 20;
    	// }
    	// if(PP>=700 ){
    	// 	dolly.GetComponent<CinemachineDollyCart>().m_Speed = 10;
    	// }
    	if(PP>=2386 ){
    		SceneManager.LoadScene("End Game");
    	}
    	//dolly.GetComponent<CinemachineDollyCart>().m_Speed = 20;
    	Debug.Log(Spd);
    }
}
//https://docs.unity3d.com/Packages/com.unity.cinemachine@2.1/api/Cinemachine.CinemachinePath.html
