using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firesmile : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite smile;
    SpriteRenderer s;
    void Start()
    {
        s = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        StartCoroutine(ExecuteAfterTime(5f));
        StartCoroutine(DelayedLoad("Home", 8f));
    }

    IEnumerator DelayedLoad(string newScene, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);
    }

    IEnumerator ExecuteAfterTime(float delay){
        yield return new WaitForSeconds(delay);
        s.sprite = smile;
    }
}
