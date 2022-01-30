using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionHandler : MonoBehaviour
{
    // private SpriteRenderer platform;
    public UnityEvent onCollision;

    private void OnCollisionEnter2D(Collision2D other) {
        onCollision.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        onCollision.Invoke();
    }
}
