using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    bool shake = false;

    // Start is called before the first frame update
    void Start()
    {   
        shake = false;
        gameObject.GetComponent<Renderer>().enabled = false;
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        print("Start");
        yield return new WaitForSeconds(3);
        shake = true;
        gameObject.GetComponent<Renderer>().enabled = true;
        // Have buttons working
        // Button accept and button deny
        print("End");
    }


    void OnMouseDown(){
        print(name);
        if(name == "phoneDeny"){
            SceneManager.LoadScene(2);
        }
        else if(name == "phoneAccept"){
            SceneManager.LoadScene(1);
        }
    }
    
    // public void MoveToScene(int sceneID)
    // {
    //     SceneManager.LoadScene(sceneID);
    // }


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
