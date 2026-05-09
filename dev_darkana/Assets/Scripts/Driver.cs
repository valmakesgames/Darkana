using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float steerSpeed;

    private void Update() {
        float move = 0;
        float steer = 0;
        
        // WASD Movement/Steering
        if (Keyboard.current.wKey.isPressed) {
            move = 1f;
            Debug.Log("FORWARD (W key pressed)");
        } else if 
            (Keyboard.current.sKey.isPressed) {
            move = -1f;
            Debug.Log("DOWN (S key pressed)");
        } 
        if (Keyboard.current.aKey.isPressed) { 
            steer = 1f;
            Debug.Log("LEFT (A key pressed)");
        } else if 
            (Keyboard.current.dKey.isPressed) {
            steer = -1f;
            Debug.Log("RIGHT (D key pressed)");
        }

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount =  steer * steerSpeed * Time.deltaTime;
        
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}
