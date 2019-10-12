using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneMovement_group1 : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform target;
    public int wavepointIndex = 0;
    private int targetnumber = 0;
    GameObject enemyWaypoints;
    private float z;
    private float rX;
    private float rotationSpeed;
    private bool rotateZ;
    private bool zPos;
    private bool zNeg;
    

    void Start ()
    {
        enemyWaypoints = GameObject.Find("droneWaypoints01");
        target = enemyWaypoints.GetComponent<droneWaypoint_group1>().points[targetnumber].transform;
        z = 0.0f;
        rX = 0.0f;
        rotationSpeed = 60.0f;
        rotateZ = true;
        zPos = false;
        zNeg = false;
    }

    void Update()
    {
        Vector3 dir = target.transform.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (zPos == true && zNeg == false && rotateZ == true)
        {
            z -= Time.deltaTime * rotationSpeed;
            if (z < Random.Range(-45.0f, -25.0f))
            {
                rotateZ = false;
            }
        }
        if (zPos == true && zNeg == false && rotateZ == false)
        {
            z += Time.deltaTime * rotationSpeed * 2;
            if (z > 0.0f)
            {
                z = 0.0f;
                zPos = false;
            }
        }
        if (zPos == false && zNeg == true && rotateZ == true)
        {
            z += Time.deltaTime * rotationSpeed;
            if (z > Random.Range(25.0f, 45.0f))
            {
                rotateZ = false;
            }
        }
        if (zPos == false && zNeg == true && rotateZ == false)
        {
            z -= Time.deltaTime * rotationSpeed * 2;
            if (z < 0.0f)
            {
                z = 0.0f;
                zNeg = false;
            }
        }
        transform.localRotation = Quaternion.Euler(0, 90, z);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        wavepointIndex++;
        if (wavepointIndex >= enemyWaypoints.GetComponent<droneWaypoint_group1>().points.Length - 1)
        {
            Destroy(gameObject);
        }
               
        target = enemyWaypoints.GetComponent<droneWaypoint_group1>().points[wavepointIndex].transform;
        rotateZ = true;
        rX = Random.Range(-2.0f, 2.0f);
        rotationSpeed = Random.Range(40.0f, 70.0f);
        if (rX >= 0.01f)
        {
            zPos = true;
        }
        if (rX <= -0.01f)
        {
            zNeg = true;
        }
    }
}

