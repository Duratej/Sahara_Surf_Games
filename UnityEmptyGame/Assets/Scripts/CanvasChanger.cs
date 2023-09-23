using UnityEngine;

public class CanvasChanger : MonoBehaviour {
    public static int CanvasNumber;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject canvas6;
    public GameObject canvas7;
    public GameObject canvas8;

    void Start() {
        CanvasNumber = 1;
    }
    public void popUpOpenCanvas(int open) {
        if (open == 1) {
            canvas1.SetActive(true);
        } else if (open == 2) {
            canvas2.SetActive(true);
        } else if (open == 3) {
            canvas3.SetActive(true);   
        } else if (open == 4) {
            canvas4.SetActive(true);
        } else if (open == 5) {
            canvas5.SetActive(true);
        } else if (open == 6) {
            canvas6.SetActive(true);
        } else if (open == 7) {
            canvas7.SetActive(true);
        } else {
            Debug.Log("Error");
        }
    }
    public void popUpCloseCanvas(int close) {
        if (close == 1) {
            canvas1.SetActive(false);
        } else if (close == 2) {
            canvas2.SetActive(false);
        } else if (close == 3) {
            canvas3.SetActive(false);   
        } else if (close == 4) {
            canvas4.SetActive(false);
        } else if (close == 5) {
            canvas5.SetActive(false);
        } else if (close == 6) {
            canvas6.SetActive(false);
        } else if (close == 7) {
            canvas7.SetActive(false);
        } else if (close == 8) {
            canvas8.SetActive(false);
        }
    }
        public void SwapCanvas(int newNum) {
        CanvasNumber = newNum;

        if (CanvasNumber == 1) {
            canvas1.SetActive(true);
        }   else {
            canvas1.SetActive(false);
        }
        if (CanvasNumber == 2) {
            canvas2.SetActive(true);
        } else { 
            canvas2.SetActive(false);
        }
        if (CanvasNumber == 3) {
            canvas3.SetActive(true);
        } else { 
            canvas3.SetActive(false);
        }
        if (CanvasNumber == 4) {
            canvas4.SetActive(true);
        } else { 
            canvas4.SetActive(false);
        }
        if (CanvasNumber == 5) {
            canvas5.SetActive(true);
        } else { 
            canvas5.SetActive(false);
        }
        if (CanvasNumber == 6) {
            canvas6.SetActive(true);
        } else { 
            canvas6.SetActive(false);
        }
        if (CanvasNumber == 7) {
            canvas7.SetActive(true);
        } else { 
            canvas7.SetActive(false);
        }
        if (CanvasNumber == 8) {
            canvas8.SetActive(true);
        } else { 
            canvas8.SetActive(false);
        }
    }
}
