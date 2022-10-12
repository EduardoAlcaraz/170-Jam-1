using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_direction = Input.GetAxis("Horizontal");
        float vertical_direction = Input.GetAxis("Vertical");
        var transform = this.GetComponent<Transform>(); //Can also be written as Transform transform = this.GetCompo....
        var position = transform.position;
        position.x += horizontal_direction * this.speed * Time.deltaTime;
        position.y += vertical_direction * this.speed * Time.deltaTime;
        transform.position = position;

        if (horizontal_direction > 0)
        {
            gameObject.transform.localScale = new Vector3(-4f, 4f, 4f);
        }

        if (horizontal_direction < 0)
        {
            gameObject.transform.localScale = new Vector3(4f, 4f, 4f);
        }
    }
}
