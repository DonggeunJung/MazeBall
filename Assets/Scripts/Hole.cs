using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {
    public bool fallIn = false;
    // 어떤 공을 빨아 들일지를 태그로 지정
    public string activeTag;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == activeTag)
        {
            fallIn = true;
        }
    }

    void OnGUI()
    {
        if( fallIn == true )
            GUI.Label(new Rect(0, 0, 100, 30), "You Win. Very good. Game Clear!");
    }
}
