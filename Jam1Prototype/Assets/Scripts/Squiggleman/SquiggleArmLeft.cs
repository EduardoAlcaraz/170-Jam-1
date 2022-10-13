using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquiggleArmLeft : MonoBehaviour
{
    
    public GameObject leftArm;
    public GameObject rightArm;
    public GameObject leftLeg;
    public GameObject rightLeg;
    private float increment = 30f;
    private bool ending = false;

    // Start is called before the first frame update
    void Start()
    {
        leftArm = GameObject.Find("left_arm2");
        rightArm = GameObject.Find("right_arm2");
        leftLeg = GameObject.Find("left_leg2");
        rightLeg = GameObject.Find("right_leg2");

        leftArm.transform.Rotate(0f, 0f, increment*11, Space.Self);
        rightArm.transform.Rotate(0f, 0f, increment*9, Space.Self);
        leftLeg.transform.Rotate(0f, 0f, increment*7, Space.Self);
        rightLeg.transform.Rotate(0f, 0f, increment*4, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
            leftArm.transform.Rotate(0f, 0f, increment, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) {
            rightArm.transform.Rotate(0f, 0f, -increment, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            leftLeg.transform.Rotate(0f, 0f, increment, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {
            rightLeg.transform.Rotate(0f, 0f, -increment, Space.Self);
        }
        
    }
}
