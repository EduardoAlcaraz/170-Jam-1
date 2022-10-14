using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class petcat : MonoBehaviour
{
    public Sprite cat_down;
    public Sprite cat_up;
    SpriteRenderer s;
    void Start(){
        s = gameObject.GetComponent<SpriteRenderer>();
    }
    

    // Update is called once per frame
    void Update()
    {
        bool isPressed = Input.GetKeyDown(KeyCode.Space);
        if(isPressed){
            if(s.sprite == cat_down){
                s.sprite = cat_up;
            }else{
                s.sprite = cat_down;
            }
        }
    }
}
