using UnityEngine;

public class Scaler : MonoBehaviour {
    private Camera mainCamera;
    public int defualtX;
        public int defualtY;
        private float screenX; //float inorder to avoid int division
        private float screenY;
        private bool yScaleBigger; //if X is bigger this is false
        
        private float finalScale;

    void Start() {
        mainCamera = Camera.main;
        screenX = Screen.width;
        screenY = Screen.height;
        yScaleBigger = true;
        if (defualtX / screenX >= defualtY / screenY) {
            yScaleBigger = false;
        }
        if (yScaleBigger) {
            finalScale = screenY / defualtY;
        } else {
            finalScale = screenX / defualtX;
        }
        mainCamera.orthographicSize *= finalScale;
        Debug.Log(defualtX);
        Debug.Log(defualtY);
        Debug.Log(screenX);
        Debug.Log(screenY);
        Debug.Log(finalScale);
    }
}
