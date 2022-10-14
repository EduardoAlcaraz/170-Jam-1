using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCollision : MonoBehaviour
{
    public float SceneID = 1f;
    public string NextScene = "SquigglyMan";

    // Start is called before the first frame update
    void Start()
    {
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D hit) {
        if(hit.transform.gameObject.name == "BedCollider")
        {
           Debug.Log("hit " + hit.transform.gameObject.name);
           Debug.Log(SceneID);
           SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
        }
    }
}
