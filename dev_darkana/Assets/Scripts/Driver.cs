using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float steerSpeed;
    [SerializeField]
    float moveSpeed;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Keyboard.current.wKey.isPressed) {
            transform.Translate(0, moveSpeed, 0);
            Debug.Log("FORWARD (W key pressed)");
        }

        if (Keyboard.current.aKey.isPressed) {
            transform.Rotate(0, 0, steerSpeed);
            Debug.Log("LEFT (A key pressed)");
        }

        if (Keyboard.current.sKey.isPressed) {
            transform.Translate(0, -moveSpeed, 0);
            Debug.Log("DOWN (S key pressed)");
        }

        if (Keyboard.current.dKey.isPressed) {
            transform.Rotate(0, 0, -steerSpeed);
            Debug.Log("RIGHT (D key pressed)");
        }
        
        // transform.Rotate(0, 0, steerSpeed);
        // transform.Translate(0, moveSpeed, 0);
    }
}
