using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : BasicEnemy
{
    public GameObject player;
    public GameObject firePoint;
    public float _xValue;
    public float _yValue;
    public float fireTime;
    public float fireDelay = 0.5f;
    public GameObject shot;
    public float shotspeed;
    private float vecLengFlt;
    public float ratioX;
    public float ratioY;

    public int health;

    // Start is called before the first frame update
    void Start()
    {

    }
    //https://answers.unity.com/questions/254130/how-do-i-rotate-an-object-towards-a-vector3-point.html source for the below code
    public Transform Target;
    public float RotationSpeed;

    //values for internal use
    private Quaternion _lookRotation;
    private Vector3 _direction;

    // Update is called once per frame
    protected override void Update()
    {
        //5 +2.75
        try
        {
            _xValue = this.transform.position.x - player.transform.position.x;
            _yValue = this.transform.position.y - player.transform.position.y;
            //ratioX = 5f - this.transform.position.x;
            //ratioY = 2.75f - this.transform.position.y;
            vecLengFlt = Mathf.Sqrt((_xValue * _xValue) + (_yValue * _yValue));


            ratioX = _xValue/vecLengFlt;
            ratioY = _yValue/vecLengFlt;
            //find the vector pointing from our position to the target
            _direction = (Target.position - transform.position).normalized;

            //create the rotation we need to be in to look at the target
            _lookRotation = Quaternion.LookRotation(_direction);

            //rotate us over time according to speed until we are in the required rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
        }
        catch { }
        if (fireTime < Time.time)
        {
            Fire();
            fireTime = Time.time + fireDelay;
        }
        base.Update();
    }
    public void Fire()
    {
        GameObject Shot = Instantiate(shot, this.transform.position + new Vector3(-.1f, 0, 0), transform.rotation);
        Shot.transform.parent = this.transform.parent;
        Shot.GetComponent<BulletMovement>().Angle(-ratioX, -ratioY, shotspeed);
        Shot.transform.rotation = _lookRotation;

    }
}