using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootSingle : BasicEnemy
{
    public float fireTime;
    public float fireDelay = 1.0f;
    public GameObject shot;
    public float shotspeed;

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
        Movement(-0.002f, 0, 0.1f);
        base.Update();
    }
    void Fire()
    {
        GameObject Shot = Instantiate(shot, this.transform.position + new Vector3(-.1f,0,0), transform.rotation);
        Shot.transform.parent = this.transform.parent;
        Shot.GetComponent<BulletMovement>().horz = shotspeed;
    }
}
