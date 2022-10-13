using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquiggleArmLeft : MonoBehaviour
{
    
    public GameObject leftArm;
    public GameObject rightArm;
    public GameObject leftLeg;
    public GameObject rightLeg;

    // Start is called before the first frame update
    void Start()
    {
        leftArm = GameObject.Find("left_arm2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("key detected " + leftArm.name);
            leftArm.transform.Rotate(0f, 0f, 30f, Space.Self);
        }
        
    }
}
