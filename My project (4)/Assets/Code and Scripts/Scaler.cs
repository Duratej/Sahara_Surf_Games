using UnityEngine;

public class Scaler : MonoBehaviour {
    private Camera mainCamera;
    public float defualtX;
        public float defualtY;
        private float screenX = 1; //float inorder to avoid int division
        private float screenY= 1;        
        private float finalScale;

    void Start() {
        mainCamera = Camera.main;
        screenX = Screen.width;
        screenY = Screen.height;
        finalScale = 1;
        //camera auto fixes if screen is proportionally wider than area but not if taller.
        if (screenY/screenX > defualtY/defualtX) {
            finalScale =(screenY/screenX) / (defualtY/defualtX); 
        }
        mainCamera.orthographicSize *= finalScale;
        Debug.Log(defualtX);
        Debug.Log(defualtY);
        Debug.Log(screenX);
        Debug.Log(screenY);
        Debug.Log(finalScale);
    }
}
