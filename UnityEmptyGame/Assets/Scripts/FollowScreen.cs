using UnityEngine;

public class followScreen : MonoBehaviour {
    void Update() {
        transform.position = new Vector3(20*ScreenTracker.getScreenNumber() - 60, 0, -1);    
    }
}
