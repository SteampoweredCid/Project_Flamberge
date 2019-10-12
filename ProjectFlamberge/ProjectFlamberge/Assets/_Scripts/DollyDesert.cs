using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;


public class DollyDesert : MonoBehaviour
{
    private Animator anim;

    public GameObject Camera;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    // Start is called before the first frame update
   void Start()
    {
        anim = Camera.GetComponent<Animator>();
        Setlevel("level1v2");
    }

    void Setlevel(string scene)
    {
        //string scene = "City";Debug.Log(PlayerPrefs.HasKey(scene));
        PlayerPrefs.SetString("sceneName", scene);

        Debug.Log("Level set to " + PlayerPrefs.GetString(scene));
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.HasKey(scene));
    }

    private float PP;
    private float Spd;
    public CinemachineDollyCart dolly;
    void Update()
    {
        PP = dolly.GetComponent<CinemachineDollyCart>().m_Position;

        if (PP >= 50 && PP <= 51)
        {
            
                enemy1.SetActive(true);
        }
        if (PP >= 75)
        {
            Camera.SetActive(true);
            
        }
        if(PP>= 250&& PP <= 251){
            Camera.GetComponent<Animator>().Play("pan back");
        }
        if (PP >= 306 && PP <= 307)
        {
            enemy2.SetActive(true);
        }
        if (PP >= 750)
        {
            SceneManager.LoadScene("City");
        }
    }
}
//https://docs.unity3d.com/Packages/com.unity.cinemachine@2.1/api/Cinemachine.CinemachinePath.html
