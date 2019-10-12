using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTimerSystem : MonoBehaviour
{
    public float ActivationTimer = 2.5f;
    public float DelayTimer = 5f;
    public ParticleSystem PS;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivateLaser());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ActivateLaser()
    {
        PS.Play();
        yield return new WaitForSeconds(ActivationTimer);
        StartCoroutine(DeactivateLaser());
    }
    IEnumerator DeactivateLaser()
    {
        PS.Stop();
        yield return new WaitForSeconds(DelayTimer);
        StartCoroutine(ActivateLaser());
    }

}
