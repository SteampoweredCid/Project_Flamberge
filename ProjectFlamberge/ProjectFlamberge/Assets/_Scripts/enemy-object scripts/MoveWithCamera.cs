using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithCamera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Movement() { }
    public void Movement(float hor, float ver)
    {
        Vector3 movement = new Vector3(hor, ver, 0.0f);
        Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
        gameObject.transform.position += relativeMovement *0.1f;
        Vector3 clampedPosition = gameObject.transform.localPosition;
        //clampedPosition.x = Mathf.Clamp(clampedPosition.x, -5, 5);
        //clampedPosition.y = Mathf.Clamp(clampedPosition.y, -3, 3);
        gameObject.transform.localPosition = clampedPosition;
    }
    // Update is called once per frame
    public void Movement( float hor, float ver, float spd)
    {



        Vector3 movement = new Vector3(hor, ver, 0.0f);
        Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
        gameObject.transform.position += relativeMovement * spd;
        Vector3 clampedPosition = gameObject.transform.localPosition;
        //clampedPosition.x = Mathf.Clamp(clampedPosition.x, -5, 5);
        //clampedPosition.y = Mathf.Clamp(clampedPosition.y, -3, 3);
        gameObject.transform.localPosition = clampedPosition;
    }
}
