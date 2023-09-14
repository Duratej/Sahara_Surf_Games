using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class everythingForRn : MonoBehaviour {
    public static int screenTracker = 3;
    public static int getScreenTracker() {
        return screenTracker;
    }
    void Update() {
        if (Input.GetKey("d")) {
            screenTracker++;
        }
        if (Input.GetKey("a")) {
            screenTracker--;
        }
        Debug.Log(screenTracker);
    } 
}
