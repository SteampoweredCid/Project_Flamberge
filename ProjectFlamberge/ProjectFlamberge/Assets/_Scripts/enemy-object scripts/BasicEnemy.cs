using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MoveWithCamera
{
    public bool rest;
    public bool train;
    private Vector3 clampedPosition;
    private float x;
    private float y;
    public bool isKilled;

    public float xDis;
    public float yDis;
    public float upTime;
    public bool inPlay;
    // Start is called before the first frame update
    void Start()
    {
        upTime = Time.time;
    }
    //private void OnTriggerEnter(Collider collision)
    //{ Debug.Log("Trigger entered \n");
    //    switch
    //     (collision.gameObject.tag)
    //    { 
    //        case "KillPlane":
    //        Destroy(gameObject);
    //            isKilled = true;    
    //    break;

    //    default:
    //    break;
    //}
    //}
     virtual protected void Update()
    {
        if (Time.time >= upTime && inPlay) {
            xDis = this.transform.position.x - Camera.main.transform.position.x;

            yDis = this.transform.position.y - Camera.main.transform.position.y;

            if (Mathf.Abs(xDis) > 7 || Mathf.Abs(yDis) > 3)
            {
                Destroy(gameObject);
            }
            upTime = Time.time + 0.5f;
        }
        //if (rest)
        //{
        //    if (train)
        //    {
        //        Movement(0.2f, -0.2f, 2f);
        //    }
        //    else
        //    {
        //        Movement(-0.4f, .2f, 2f);
        //    }
        //}
    }
    // Update is called once per frame
    //void Update()
    //{ if (Input.GetButtonDown("Fire3"))
    //    {
    //        GameObject Shot = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    //        Shot.GetComponent<enemyDummyBullet>().spawner = gameObject;
    //    }
    //    if (train)
    //    {
    //        StartCoroutine("Travel");
    //        train = false;
    //    }

    //}
    //IEnumerator Travel()
    //{
    //    for(float i = 1000;i>=0; i++){
    //    Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
    //    Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
    //    gameObject.transform.position += relativeMovement * speed;
    //    yield return null;
    //    }
    //}
}
