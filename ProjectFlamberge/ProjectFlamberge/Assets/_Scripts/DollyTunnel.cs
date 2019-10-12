using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;


public class DollyTunnel : MonoBehaviour
{
   
    private float PP;
    private float Spd;
    public CinemachineDollyCart dolly;

    private Animator anim;

    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        anim = Camera.GetComponent<Animator>();
    }

    void Update()
    {
        PP = dolly.GetComponent<CinemachineDollyCart>().m_Position;
        
        if(PP>=80 ){
            Camera.SetActive(true);
            //anim.Play("pan side", 0, 0);
        }
        if (PP >= 150)
        {
            SceneManager.LoadScene("level1v2");
        }
        //dolly.GetComponent<CinemachineDollyCart>().m_Speed = 20;
        //Debug.Log(Spd);
    }
}
//https://docs.unity3d.com/Packages/com.unity.cinemachine@2.1/api/Cinemachine.CinemachinePath.html
