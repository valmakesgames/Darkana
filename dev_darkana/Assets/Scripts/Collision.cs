using System;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D() {
        Debug.Log(gameObject.name + " collided! ");
    }
}