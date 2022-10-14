using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SquiggleArmLeft : MonoBehaviour
{
    
    public GameObject leftArm;
    public GameObject rightArm;
    public GameObject leftLeg;
    public GameObject rightLeg;
    private float increment = 30f;
    private bool ending = false;
    System.Random rand = new System.Random();
    AudioSource audioData;
    AudioSource completeSound;
    private bool correctLA = false;  //these bools keep track of whether the limbs are in the correct rotation or not.
    private bool correctRA = false;  //RA stands for Right Leg, LL for Left Leg, LA for Left Arm, and RL for Right Arm.
    private bool correctLL = false;
    private bool correctRL = false;

    // Start is called before the first frame update
    void Start()
    {
        leftArm = GameObject.Find("left_arm2");
        rightArm = GameObject.Find("right_arm2");
        leftLeg = GameObject.Find("left_leg2");
        rightLeg = GameObject.Find("right_leg2");

        //leftArm.transform.Rotate(0f, 0f, increment*11, Space.Self);  //330
        //rightArm.transform.Rotate(0f, 0f, increment*9, Space.Self);  //270
        //leftLeg.transform.Rotate(0f, 0f, increment*7, Space.Self);  //210
        //rightLeg.transform.Rotate(0f, 0f, increment*4, Space.Self);  //120

        audioData = GetComponent<AudioSource>();
        completeSound = GameObject.Find("right_arm2").GetComponent<AudioSource>();  //Unity only lets each game object have one audio source.  right_arm2 has the audio that will play indicating that all limbs are in the right place
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
            if (newAngleLA > -1 && newAngleLA < 1) { 
                Debug.Log("Left Arm zero"); 
                correctLA = true;
                audioData.Play();
            } else correctLA = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) {
            rightArm.transform.Rotate(0f, 0f, -increment, Space.Self);
            newAngleRA = rightArm.transform.localEulerAngles.z;
            if (newAngleRA > -1 && newAngleRA < 1) {
                Debug.Log("Right Arm Zero");
                correctRA = true;
                audioData.Play();
            } else correctRA = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            leftLeg.transform.Rotate(0f, 0f, increment, Space.Self);
            newAngleLL = leftLeg.transform.localEulerAngles.z;
            //Debug.Log(leftLeg.transform.localEulerAngles.z.ToString() + "    " + rand.Next(0, 100000).ToString());
            if (newAngleLL > -1 && newAngleLL < 1) {
                Debug.Log("Left Leg zero");
                correctLL = true;
                audioData.Play();
            } else correctLL = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {
            rightLeg.transform.Rotate(0f, 0f, -increment, Space.Self);
            newAngleRL = rightLeg.transform.localEulerAngles.z;
            if (newAngleRL > -1 && newAngleRL < 1) {
                Debug.Log("Right Leg zero");
                correctRL = true;
                audioData.Play();
            } else correctRL = false;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            //Debug.Log(correctLA);
        }

        if (correctLL && correctRL && correctLA && correctRA && !ending) {
            ending = true;
            //SceneManager.LoadScene("Home", LoadSceneMode.Single);
            StartCoroutine(DelayedLoad("Home", 3f));
        }
        
    }

    IEnumerator DelayedLoad(string newScene, float delay) {
        Debug.Log("delayed load");
        completeSound.Play();
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);
    }
}
