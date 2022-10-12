using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCollision : MonoBehaviour
{
    string SceneID = "Bedroom1";

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
           SceneManager.LoadScene("BananaRoom", LoadSceneMode.Single);
        }
    }
}
