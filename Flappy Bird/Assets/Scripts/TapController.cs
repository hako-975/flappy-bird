using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController : MonoBehaviour
{
    public float velocity = 1.5f;
    public float rotationSpeed = 10f;

    public AudioSource sfx_wing;

    public Rigidbody2D bird;

    private void OnMouseDown()
    {
        sfx_wing.Play();
        bird.velocity = Vector2.up * velocity;
    }

    private void FixedUpdate()
    {
        bird.transform.rotation = Quaternion.Euler(0, 0, bird.velocity.y * rotationSpeed);
    }
}
