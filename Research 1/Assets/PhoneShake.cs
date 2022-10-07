using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneShake : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite1;
    bool shake = false;

    // Start is called before the first frame update
    void Start()
    {    
        shake = false;
        StartCoroutine(Phone1());
    }

    IEnumerator Phone1()
    {
        print("Start");
        yield return new WaitForSeconds(3);
        ChangeSprite1();
        shake = true;
        // Have buttons working
        // Button accept and button deny
        print("End");
    }

    void ChangeSprite1(){
        spriteRenderer.sprite = newSprite1;
    }

    // Update is called once per frame
    void Update()
    {
        if (shake){
            var transform = this.GetComponent<Transform>();
            var position = transform.position;
            var  speed = 30.0f; //how fast it shakes
            var  amount = 0.002f; //how much it shakes
            position.x += Mathf.Sin(Time.time * speed) * amount;
            position.y += Mathf.Sin(Time.time * speed) * amount;
            transform.position = position;
        }
    }
}
