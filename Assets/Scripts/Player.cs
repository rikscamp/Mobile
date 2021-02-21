using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Controls controls;

    public Rigidbody2D rigidB;

    public float moveSpeed = 1f;

    public Vector2 move;

    private void Awake()
    {
        controls = new Controls();

        //Movement 
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement Functionality 
        rigidB.velocity = move * (moveSpeed * Time.deltaTime);
    }



    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}

