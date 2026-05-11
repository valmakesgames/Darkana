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
    GameObject truckTailLights;

    private bool isMoving = false;

    void Awake() {
            truckTailLights.SetActive(true);
    }
    
    void Update() {
        float move = 0;
        float steer = 0;
        
        isMoving = false;
        
        // WASD Movement/Steering
        if (Keyboard.current.wKey.isPressed) {
            isMoving = true;
            move = 1f;
        } else if
            (Keyboard.current.sKey.isPressed) {
            isMoving = true;
            move = -1f;
        } 
        
        if (Keyboard.current.aKey.isPressed) { 
            isMoving = true;
            steer = 1f;
        } else if 
            (Keyboard.current.dKey.isPressed) {
            isMoving = true;
            steer = -1f;
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
