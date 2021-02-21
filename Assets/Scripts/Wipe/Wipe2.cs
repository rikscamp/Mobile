using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wipe2 : MonoBehaviour
{
    Controls controls;

    public Vector2 stickPos;




    public bool canTickUp;
    public int wipe = 0;
    public bool leftEyeClean;


    //Right Eye
    public GameObject Wipe1;


    private void Awake()
    {
        controls = new Controls();


        controls.Wipes.smearL.performed += ctx => stickPos = ctx.ReadValue<Vector2>();
        controls.Wipes.smearL.canceled += ctx => stickPos = Vector2.zero;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(canTickUp);
        Debug.Log(wipe);
        //Debug.Log(stickPos);



        if (stickPos.x == 0)
        {
            canTickUp = true;

        }
        if (stickPos.x < -0.7 && canTickUp == true)
        {

            canTickUp = false;


        }
        else if (stickPos.x > -0.5 && canTickUp == false)
        {
            canTickUp = true;
            wipe = wipe + 1;
        }

        if (wipe == 10)
        {
            Debug.Log("clean Left eye");
            leftEyeClean = true;
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
