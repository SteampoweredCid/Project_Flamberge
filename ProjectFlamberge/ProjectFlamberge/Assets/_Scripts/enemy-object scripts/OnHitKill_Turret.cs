using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnHitKill_Turret : MonoBehaviour
{
    //public string SceneToLoad;
    public GameObject Turret;
    public int health;
    public GameObject explosion;

    void Update()
    { }
       

    public void OnCollisionEnter(Collision other)
    {
        if (health!=0)
        {
            health--;
        }
        if (health == 0)
        {
            Instantiate(explosion,transform.position,transform.rotation);
            //explosion.timeoutDestructor = .2;
            Destroy(gameObject);
        }
        Destroy(other.gameObject);
        //Destroy(gameObject);
    }
}
