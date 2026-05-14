using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D() {
        Debug.Log(gameObject.name + " collided! ");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered " + other.name);
    }
}