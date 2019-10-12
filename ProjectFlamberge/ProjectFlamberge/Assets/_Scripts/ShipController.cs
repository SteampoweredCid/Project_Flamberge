using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
    public Image HealthBarFill;
    private Animator animatorWings;
    public float speed;
    public float tilt;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float health = 100.0f;
    public float playerInv = 1f;
    public float playerTime = 0f;
    private float nextFire;
    

    public float Boundary_Horizontal = 5.0f;
    public float Boundary_Vertical = 2.75f;
    public GameObject BoltDeath;
    private void Start()

    {
        animatorWings = GetComponent<Animator>();
    }

    public void TakeDamage(float incomingDamage)    // <----- no semicolon here
    {
        Debug.Log("THE PLAYER IS TAKING DAMAGE!!");
        if (health > incomingDamage)
        {
            health -= incomingDamage;
        }
        else
        {
            health -= incomingDamage;
            BoltDeath.SetActive(true);

        }
    }

    void Update()
    {
        //health stuff here
        HealthBarFill.fillAmount = health / 100.0f; // <------------------------------

        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            if (Input.GetButton("Jump") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject Shot = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                Shot.transform.parent = Camera.main.transform;
               
            }
        }
    }



    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //movement change raw
        float moveVertical = Input.GetAxis("Vertical"); //movement change raw
        if (animatorWings != null)
        {
            animatorWings.SetFloat("Blend", moveVertical);
        }
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
        gameObject.transform.position += relativeMovement * speed;

        Vector3 clampedPosition = gameObject.transform.localPosition;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -Boundary_Horizontal, Boundary_Horizontal);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -Boundary_Vertical, Boundary_Vertical);

        gameObject.transform.localPosition = clampedPosition;
    }

    public void InvTime()
    {
        playerTime = Time.time + playerInv;
    }
}
