﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wipe : MonoBehaviour
{
    Controls controls;

    public Vector2 stickPos;

    public GameObject bigTear;
    public GameObject smearTear;

    public AudioSource squeak;
    public AudioSource squeak2;


    public bool canTickUp;
    public int wipe = 0;
    public bool rightEyeClean;
    

    //Right Eye
    public GameObject Wipe1;


    private void Awake()
    {
        controls = new Controls();


        controls.Wipes.smear.performed += ctx => stickPos = ctx.ReadValue<Vector2>();
        controls.Wipes.smear.canceled += ctx => stickPos = Vector2.zero;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(canTickUp);
        //Debug.Log(wipe);
        //Debug.Log(stickPos);
        


        if (stickPos.x == 0)
        {
            canTickUp = true;

        }       
        if (stickPos.x > 0.7 && canTickUp == true)
        {
            
            canTickUp = false;
            
          
        }
        else if (stickPos.x < 0.5 && canTickUp == false)
        {
            canTickUp = true;
            CountUp();
        }

       
    }

    private void CountUp()
    {
        wipe = wipe + 1;
        switch (wipe)
        {
            case 6:
                squeak2.Play();
                smearTear.SetActive(false);
                Debug.Log("clean right eye");
                rightEyeClean = true;
                //Todo 

                break;
            case 5:
                squeak2.Play();
                //Todo 

                break;
            case 4:
                squeak.Play();
                //Todo 

                break;
            case 3:
                squeak2.Play();
                bigTear.SetActive(false);
                smearTear.SetActive(true);
                //Todo 

                break;
            case 2:
                squeak.Play();
                //Todo 

                break;
            case 1:
                squeak2.Play();
                //Todo 

                break;
        }

    }
    
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
