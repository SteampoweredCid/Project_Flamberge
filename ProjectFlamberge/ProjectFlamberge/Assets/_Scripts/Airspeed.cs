using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Airspeed : MonoBehaviour
{
    //GameObject playerShip;
    float magnitude;
    //TextMeshPro text;
    public TextMeshProUGUI newText;
    float airspeed;
    private float updateTimer = 1;
    public int speedMultiplier;

    public ShipController playerController;

    // Start is called before the first frame update
    void Start()
    {
        //playerShip = GameObject.FindWithTag("Player");
        newText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        updateTimer -= Time.deltaTime;

        if (updateTimer <= 0)
        {
            magnitude = playerController.magnitude;
            airspeed = magnitude * speedMultiplier;
            newText.text = airspeed.ToString("N0");
            updateTimer = 1;

        }

    }
}
