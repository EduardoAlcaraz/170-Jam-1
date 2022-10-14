using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spin : MonoBehaviour
{
    float old = 0;
    float fresh = 0;
    float max = 3000;
    float value = 0;
    static public float progress = 0;
    bool spinning = true;
    void FixedUpdate() {
        if (Input.GetMouseButton(0)){
            if(spinning){
                Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                difference.Normalize();
                float rotationZ = Mathf.Atan2(difference.y,difference.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f,0f,rotationZ);
                old = fresh;
                fresh = rotationZ +180f;
                value = (fresh - old) *-1;

                if(value < -100){
                    value = 0;
                }
                else if(value > 100){
                    value = 0;
                }

                progress += value / max;
                
                if(progress < 0){
                    progress = 0;
                }
                if(progress >= 1){
                    spinning = false;
                    progress = 1;
                    StartCoroutine(DelayedLoad("fire", 3f));
                }
                Debug.Log(progress);
            }
        }
    }   

    IEnumerator DelayedLoad(string newScene, float delay) {
        Debug.Log("delayed load");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);
    }
}
