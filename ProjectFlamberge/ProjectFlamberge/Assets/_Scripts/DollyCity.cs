using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;


public class DollyCity : MonoBehaviour
{
    private Animator anim;

    public GameObject Camera;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;
    public GameObject enemy10;
    public GameObject enemy11;
    public GameObject enemy12;
    public GameObject enemy13;
    // Start is called before the first frame update
    void Start()
    {
        anim = Camera.GetComponent<Animator>();
        Setlevel("City");
    }

    void Setlevel(string scene)
    {
        //string scene = "City";Debug.Log(PlayerPrefs.HasKey(scene));
        PlayerPrefs.SetString("sceneName", scene);
        PlayerPrefs.Save();
        Debug.Log("Level set to " + PlayerPrefs.GetString(scene));
        
        Debug.Log(PlayerPrefs.HasKey(scene));
    }

    private float PP;
    private float Spd;
    public CinemachineDollyCart dolly;
    void Update()
    {
    	PP = dolly.GetComponent<CinemachineDollyCart>().m_Position;
    	//Debug.Log(PP);
    	// Spd = dolly.GetComponent<CinemachineDollyCart>().m_Speed;
        if(PP>=100 && PP<= 101){
            Camera.SetActive(true);
            
        }
        if(PP>=300 && PP<= 301){
            
            Camera.GetComponent<Animator>().Play("pan back");
            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 20;
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(true);
           
        }

        if(PP>= 450 && PP <= 451){
            enemy5.SetActive(true);
            enemy6.SetActive(true);
            enemy7.SetActive(true);
            enemy8.SetActive(true);
        }

        if(PP>= 460 && PP<= 461)
        {
            enemy2.SetActive(false);
            enemy3.SetActive(false);
            
        }

        //Begin enemy wave
        if(PP>=700 && PP<= 701){
            
            //Camera.GetComponent<Animator>().Play("pan back");
            enemy1.SetActive(false);
            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 35;
            enemy5.SetActive(false);
            enemy6.SetActive(false);
            
        }
        //End enemy wave

    	if(PP>=800 && PP<= 801){
            enemy13.SetActive(true);
            Camera.GetComponent<Animator>().Play("pan side");
        }
        if(PP>=900 && PP <= 901)
        {
            enemy7.SetActive(false);
            enemy8.SetActive(false);
        }
        if(PP>=1215 && PP<=1275){
            Camera.GetComponent<Animator>().Play("pan back");
            
            enemy11.SetActive(true);
            enemy12.SetActive(true);
        }

        if (PP >= 1349 && PP <= 1350)
        {
            Camera.GetComponent<Animator>().Play("pan back");
            enemy9.SetActive(true);
            enemy10.SetActive(true);
        }
            if (PP >= 1515 && PP <= 1575)
        {
            Camera.GetComponent<Animator>().Play("pan back");
            enemy9.SetActive(false);
            enemy10.SetActive(false);
            
        }

        if (PP>=1700 && PP<=1750){
            
            Camera.GetComponent<Animator>().Play("pan side");
            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 25;
            
            //enemy9.SetActive(true);
        }
        if (PP >=2049 && PP <= 2050)
        {
            
            dolly.GetComponent<CinemachineDollyCart>().m_Speed =45;
            enemy11.SetActive(false);
            enemy12.SetActive(false);


        }
        if (PP >= 2060 && PP <= 2061)
        {
            
            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 35;
           
        }
        if (PP >= 2065 && PP <= 2066)
        {

            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 15;

        }
        if (PP >= 2070 && PP <= 2071)
        {

            dolly.GetComponent<CinemachineDollyCart>().m_Speed =8;

        }
        if (PP >= 2214 && PP <= 2275)
        {

            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 15;
            Camera.GetComponent<Animator>().Play("pan back");

        }
        if (PP >= 2276 && PP <= 2280)
        {

            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 8;
            Camera.GetComponent<Animator>().Play("pan side");

        }

        if (PP >= 2330 && PP<=2331)
        {
            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 20;

        }
        if (PP >= 2375 && PP<=2376)
        {
            dolly.GetComponent<CinemachineDollyCart>().m_Speed = 4;
            Camera.GetComponent<Animator>().Play("pan back");
        }
    }
}
//https://docs.unity3d.com/Packages/com.unity.cinemachine@2.1/api/Cinemachine.CinemachinePath.html
