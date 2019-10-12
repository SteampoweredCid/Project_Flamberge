using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionPulse : MonoBehaviour
{
    //public float intensity;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;
        float emission = Mathf.SmoothStep(0.25f, 1, Mathf.PingPong(Time.time / speed, 1));
        Color baseColor = Color.white;
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        mat.SetColor("_EmissionColor", finalColor);
    }
}