using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunEnemyScript : BasicEnemy
{
    protected GameObject shotTemp;
    public float fireTime;
    float fireDelay = 3f;
    public GameObject shot1;
    public GameObject shot2;
    public GameObject shot3;
    // Start is called before the first frame update
    void Start()
    {
       
        fireTime = Time.time;
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (fireTime < Time.time)
        {
            Fire();
            fireTime = Time.time + fireDelay;
        }
        Movement(-0.2f, 0, 0.1f);
        base.Update();
    }
    void Fire()
    {

        GameObject Shot1 = Instantiate(shot1, this.transform.position + new Vector3(-.1f, 0, 0), transform.rotation);
        Shot1.transform.parent = this.transform.parent;
        
        //shotTemp.transform.Rotate(0, 0, 45);
        GameObject Shot2 = Instantiate(shot2);
        Shot2.transform.position = this.transform.position + new Vector3(-.1f, 0, 0);

        Shot2.transform.parent = this.transform.parent;
        //shotTemp.transform.Rotate(0, 0, -90);
        GameObject Shot3 = Instantiate(shot3);
        Shot3.transform.position = this.transform.position + new Vector3(-.1f, 0, 0);
        Shot3.transform.parent = this.transform.parent;

    }
}
