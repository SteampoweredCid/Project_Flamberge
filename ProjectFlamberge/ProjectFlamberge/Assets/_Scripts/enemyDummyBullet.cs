using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDummyBullet : MoveWithCamera
{
    GameObject self;
    GameObject cam;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.parent = Camera.main.transform;
       
    }
    public void SetSpawner(GameObject toSet)
    {
        spawner = toSet;
    }
    // Update is called once per frame
    void Update()
    {
        Movement(.03f, 0, 1);
    }
}
