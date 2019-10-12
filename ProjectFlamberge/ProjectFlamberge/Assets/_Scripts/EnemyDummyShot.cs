using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDummyShot : MonoBehaviour
{
    public float speed;
    public GameObject spawner;
    //public Vector3 Speed;

    void Update()
    {
        ////gameObject.localPosition + speed;
        Vector3 movement = spawner.transform.position;
        Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
        //gameObject.transform.position += relativeMovement;// * speed;
        ////Speed = (1.0f,0.0f,0.0f);
        transform.Translate(Vector3.left - relativeMovement, Space.Self);
        ////Debug.Log(spawner.transform.position);
        ////Debug.Log(gameObject.transform.position);
        //// transform.localPosition.y=0;
        //// transform.localPosition.z=0;


        //Destroy(gameObject, 1);
       // transform.Translate(Vector3.left);
        Destroy(gameObject, 1);
    }
}
