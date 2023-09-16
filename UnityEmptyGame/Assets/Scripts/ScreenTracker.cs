using UnityEngine;

public class ScreenTracker : MonoBehaviour{
    public static int screenNumber = 3;
    void Update(){
        if (Input.GetKey("1")) {
            screenNumber = 1;
        }
        if (Input.GetKey("2")) {
            screenNumber = 2;
        }
        if (Input.GetKey("3")) {
            screenNumber = 3;
        }
        if (Input.GetKey("4")) {
            screenNumber = 4;
        }
        if (Input.GetKey("5")) {
            screenNumber = 5;
        }
    }
    public static int getScreenNumber() {
        return screenNumber;
    }
    public static void setScreenNumber(int a) {
        screenNumber = a;
    }
}
