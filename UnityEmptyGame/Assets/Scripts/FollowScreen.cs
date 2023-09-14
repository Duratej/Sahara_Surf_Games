using UnityEngine;

public class FollowScreen : MonoBehaviour {
    void Update() {
    transform.position = new Vector3(TrackScreens.getScreenTracker()*20 - 60, 0,-1);  
    }
}
