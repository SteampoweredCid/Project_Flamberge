using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float health = 100.0f;
    public GameObject BoltDeath; //<----- put a GameObject here (in the Inspector) with a Bolt component on it

    // Start is called before the first frame update
    public void TakeDamage(float incomingDamage)
    {
        if (health > incomingDamage)
        {
            health -= incomingDamage;
        }
        else
        {
            BoltDeath.SetActive(true);
        }
    }
}