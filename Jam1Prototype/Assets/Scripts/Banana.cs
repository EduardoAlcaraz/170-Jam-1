using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    public AudioSource source;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        source.Play();
    }
}
