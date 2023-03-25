using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public AudioSource sfx_hit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sfx_hit.Play();
        GameManager.instance.GameOver();
    }
}
