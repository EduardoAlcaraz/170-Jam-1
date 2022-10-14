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
    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        leftArm = GameObject.Find("left_arm2");
        rightArm = GameObject.Find("right_arm2");
        leftLeg = GameObject.Find("left_leg2");
        rightLeg = GameObject.Find("right_leg2");

        leftArm.transform.Rotate(0f, 0f, increment*11, Space.Self);  //330
        rightArm.transform.Rotate(0f, 0f, increment*9, Space.Self);  //270
        leftLeg.transform.Rotate(0f, 0f, increment*7, Space.Self);  //210
        rightLeg.transform.Rotate(0f, 0f, increment*4, Space.Self);  //120
    }

    // Update is called once per frame
    void Update()
    {
        float newAngleLA;
        float newAngleRA;
        float newAngleLL;
        float newAngleRL;
        

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
            leftArm.transform.Rotate(0f, 0f, increment, Space.Self);
            newAngleLA = leftArm.transform.localEulerAngles.z;
            if (newAngleLA > -1 && newAngleLA < 1) Debug.Log("Left Arm zero"); 
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) {
            rightArm.transform.Rotate(0f, 0f, -increment, Space.Self);
            newAngleRA = rightArm.transform.localEulerAngles.z;
            if (newAngleRA > -1 && newAngleRA < 1) Debug.Log("Right Arm Zero");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            leftLeg.transform.Rotate(0f, 0f, increment, Space.Self);
            newAngleLL = leftLeg.transform.localEulerAngles.z;
            //Debug.Log(leftLeg.transform.localEulerAngles.z.ToString() + "    " + rand.Next(0, 100000).ToString());
            if (newAngleLL > -1 && newAngleLL < 1) Debug.Log("Left Leg zero");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {
            rightLeg.transform.Rotate(0f, 0f, -increment, Space.Self);
            newAngleRL = rightLeg.transform.localEulerAngles.z;
            if (newAngleRL > -1 && newAngleRL < 1) Debug.Log("Right Leg zero");
        }
        
    }
}
