using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : BasicEnemy
{
    public float horz=  .2f;
    public float vert=0f;
    public float speed=.1f;
    // Start is called before the first frame update
    void Start()
    {
        inPlay = true;
    }

    // Update is called once per frame
    protected override void Update()
    {
        Movement(horz, vert, speed);
        base.Update();
    }
    public void Angle(float x, float y)
    {
        horz = x;
        vert = y;
    }
    public void Angle(float x, float y, float sPeed)
    {
        horz = x;
        vert = y;
        speed = sPeed;
    }
}
