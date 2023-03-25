using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float velocity = 1.5f;
    public float rotationSpeed = 10f;

    public AudioSource sfx_wing;
    public AudioSource sfx_hit;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sfx_wing.Play();
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void FixedUpdate()
    {
        rb.transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sfx_hit.Play();
        GameManager.instance.GameOver();
    }
}
