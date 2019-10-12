using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireDamage : MonoBehaviour
{

    public float BulletDamage = 25.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnParticleCollision(GameObject hitObject)
    {
        Debug.Log("The BULLET hit something");
        hitObject.GetComponent<ShipController>().TakeDamage(BulletDamage);
    }

    // Update is called once per frame
    void Update()
    {

    }

}