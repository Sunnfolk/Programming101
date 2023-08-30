using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class TopDown: MonoBehaviour
{
    public float moveSpeed = 3f;
    public int health = 6;


    private void Update()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        UpdateMovement();
    }

    private void OnTriggerEnter(Collider target)
    {
        throw new NotImplementedException();
    }


    private void UpdateMovement()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector3.left * moveSpeed);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector3.right * moveSpeed);
        }


        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.forward * moveSpeed);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector3.back * moveSpeed);
        }
    }
}
