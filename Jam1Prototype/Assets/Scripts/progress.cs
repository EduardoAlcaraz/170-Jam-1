using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        bool end = false;
        
        if(isPressed){
            progInt++;
        }

        if(progInt > 10 && progInt < 20){
            s.sprite = face2;
        }else if(progInt >= 20){
            s.sprite = face3;
        }

        if(end == false && progInt >= 25){
            end = true;
            StartCoroutine(DelayedLoad("gumball", 3f));
        }
    }

    IEnumerator DelayedLoad(string newScene, float delay) {
        Debug.Log("delayed load");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);
    }
}
