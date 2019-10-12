using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTargeting : MonoBehaviour
{
    public GameObject Sub1;
    public GameObject Sub2;
    public GameObject Sub3;
    public GameObject Sub4;
    public GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Player != null)
        {
            Sub1.transform.LookAt(Player.transform);
            Sub2.transform.LookAt(Player.transform);
            Sub3.transform.LookAt(Player.transform);
            Sub4.transform.LookAt(Player.transform);
            //Sub1.transform
        }   
    }
}
