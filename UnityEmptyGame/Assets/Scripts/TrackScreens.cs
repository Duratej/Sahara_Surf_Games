using UnityEngine;

public class TrackScreens : MonoBehaviour {
    public static int screenTracker = 3;
    void Update() {
        if (Input.GetKey("1")) {
            screenTracker = 1;
        }
        if (Input.GetKey("2")) {
            screenTracker = 2;
        }
        if (Input.GetKey("3")) {
            screenTracker = 3;            
        }
        if (Input.GetKey("4")) {
            screenTracker = 4;
        }
        if (Input.GetKey("5")) {
            screenTracker = 5;
        }
           
    }
    public static int getScreenTracker() {
        return screenTracker;
    }
}
