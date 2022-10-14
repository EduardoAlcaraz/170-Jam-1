using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{

    void Update()
    {
        var position = this.transform.position;
        position.y = spin.progress * -3.8f;
        this.transform.position = position;
    }
}












