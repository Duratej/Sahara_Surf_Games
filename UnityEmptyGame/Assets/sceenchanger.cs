
using UnityEngine;

public class sceenchanger : MonoBehaviour
{
    void Update() {
        transform.position = new Vector3(everythingForRn.getScreenTracker()*20 - 60 ,0 ,-1);
    }
}