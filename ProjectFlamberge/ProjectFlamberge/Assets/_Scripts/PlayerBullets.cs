using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{

    void OnCollisionEnter(Collision hitObject)
    {
        if (hitObject.transform.GetComponent<EnemyController>() != null)
        {
            //the bullet just hit something with a "EnemyController" script on it, it MUST be an enemy!
            hitObject.transform.GetComponent<EnemyController>().TakeDamage(25.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}