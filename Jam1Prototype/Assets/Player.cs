using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.RigidBody;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    private bool colliding = false;
    Rigidbody2D prb;// = GetComponent<Rigidbody>();
    public float speed2 = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        prb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.colliding);
        //if (!this.colliding) {
            float horizontal_direction = Input.GetAxis("Horizontal");
            float vertical_direction = Input.GetAxis("Vertical");
            /*var transform = this.GetComponent<Transform>(); //Can also be written as Transform transform = this.GetCompo....
            var position = transform.position;
            position.x += horizontal_direction * this.speed * Time.deltaTime;
            position.y += vertical_direction * this.speed * Time.deltaTime;
            transform.position = position;
            */
            
            if (vertical_direction > 0) prb.AddForce(Vector2.up*speed2);
            if (vertical_direction < 0) prb.AddForce(Vector2.down*speed2);
            if (horizontal_direction > 0) prb.AddForce(Vector2.right*speed2);
            if (horizontal_direction < 0) prb.AddForce(Vector2.left*speed2);
            print(prb.velocity.x);
            
            
        //}
        //this.colliding = false;
    }

    void OnCollisionEnter2D(Collision2D col)
{
 
    //this.colliding = true;
    //print("ENTER");
 
}

    void OnCollisionExit2D(Collision2D col) {
        //this.colliding = false;
        //print("EXIT");
    }
}
