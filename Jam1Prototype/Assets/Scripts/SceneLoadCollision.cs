using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadCollision : MonoBehaviour
{
    public int sceneIndex;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
