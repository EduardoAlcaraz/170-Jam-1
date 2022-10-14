using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleChange : MonoBehaviour
{
    public int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressed = Input.GetMouseButton(0);
        if(isPressed)
        {
            SceneManager.LoadScene(sceneIndex);
        }

    }
}
