using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCollision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D hit) {
        if(hit.transform.gameObject.name == "Door")
        {
           Debug.Log("hit " + hit.transform.gameObject.name);
        }
    }
}
