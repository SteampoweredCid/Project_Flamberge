using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltCamera : MonoBehaviour

{
    private Animator anim;

    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        anim = Camera.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)){
        	Camera.SetActive(true);
            anim.Play("pan side", 0, 0);
        	//GameObject.SetActive()
        }
        if(Input.GetKeyDown(KeyCode.RightShift)){
            anim.Play("pan back", 0, 0);
        	//Camera.SetActive(false);
        }

    }

 } 