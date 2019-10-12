using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneWaypoint_group1 : MonoBehaviour {
    public Transform[] points = new Transform[1];

    void Awake ()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i).transform;
        }
    }
}
