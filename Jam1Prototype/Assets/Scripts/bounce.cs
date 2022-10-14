using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var transform = this.GetComponent<Transform>();
        var position = transform.position;
        var  speed = 5.0f; //how fast it shakes
        var  amount = 0.0005f; //how much it shakes
        position.x += Mathf.Sin(Time.time * speed) * amount;
        position.y += Mathf.Sin(Time.time * speed) * amount;
        transform.position = position;
    }
}
