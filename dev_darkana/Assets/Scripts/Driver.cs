using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float steerSpeed;

    [SerializeField]
    private GameObject truckTailLights;

    private bool isMoving = false;

    void Awake() {
            truckTailLights.SetActive(true);
            Debug.Log("Tail lights ON!");
    }
    
    void Update() {
        float move = 0;
        float steer = 0;
        
        isMoving = false;
        
        // WASD Movement/Steering
        if (Keyboard.current.wKey.isPressed) {
            isMoving = true; 
            Debug.Log("Tail lights OFF!")
            move = 1f;
            Debug.Log("FORWARD (W key pressed)");
        } else if
            (Keyboard.current.sKey.isPressed) {
            isMoving = true;
            Debug.Log("Tail lights OFF!")
            move = -1f;
            Debug.Log("DOWN (S key pressed)");
        } 
        
        if (Keyboard.current.aKey.isPressed) { 
            isMoving = true;
            steer = 1f;
            Debug.Log("LEFT (A key pressed)");
        } else if 
            (Keyboard.current.dKey.isPressed) {
            isMoving = true;
            steer = -1f;
            Debug.Log("RIGHT (D key pressed)");
        } 
        
        if (isMoving) {
            truckTailLights.SetActive(false);
        } else {
            truckTailLights.SetActive(true);
        }

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount =  steer * steerSpeed * Time.deltaTime;
        
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}
