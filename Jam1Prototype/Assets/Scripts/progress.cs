using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progress : MonoBehaviour
{

    int progInt = 0;

    public Sprite face2;
    public Sprite face3;
    SpriteRenderer s;

    // Start is called before the first frame update
    void Start()
    {
        s = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        bool isPressed = Input.GetKeyDown(KeyCode.Space);

        if(isPressed){
            progInt++;
        }

        if(progInt > 10 && progInt < 20){
            s.sprite = face2;
        }else if(progInt >= 20){
            s.sprite = face3;
        }
    }
}
