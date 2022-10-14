using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Banana : MonoBehaviour
{
    public AudioSource source;
    public int sceneIndex;
    public static int banana_count = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        source.Play();
        banana_count += 1;
        Debug.Log(banana_count);
        Debug.Log("BANANA");

        if(banana_count == 5)
        {
            //if(Input.GetKeyDown("s"))
            //{
                SceneManager.LoadScene(sceneIndex);
            //}
        }
    }
}
