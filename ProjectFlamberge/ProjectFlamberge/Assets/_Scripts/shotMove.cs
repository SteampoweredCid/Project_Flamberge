using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotMove : MonoBehaviour
{
    public float speed;
    public GameObject spawner;
    Vector3 BulletSpeed;

    void Update ()
    {

        BulletSpeed = new Vector3(speed,0.0f,0.0f);
        //gameObject.localPosition + speed;
        Vector3 movement = spawner.transform.position;
        Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
        gameObject.transform.position += relativeMovement;// * speed;
        //Speed = (1.0f,0.0f,0.0f);
        //transform.Translate(Vector3.right-relativeMovement/speed,Space.Self);
        transform.Translate(BulletSpeed,Space.Self);
       //Debug.Log(spawner.transform.position);
       //Debug.Log(gameObject.transform.position);
        // transform.localPosition.y=0;
        // transform.localPosition.z=0;


        Destroy(gameObject,0.5f);
    }
}
