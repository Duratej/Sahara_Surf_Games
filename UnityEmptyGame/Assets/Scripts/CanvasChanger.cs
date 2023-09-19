using UnityEngine;

public class CanvasChanger : MonoBehaviour {
    public static int CanvasNumber;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject canvasOptions6;
    public GameObject canvasLanguage7;

    void Start() {
        CanvasNumber = 1;
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
            canvasOptions6.SetActive(true);
        } else { 
            canvasOptions6.SetActive(false);
        }
        if (CanvasNumber == 7) {
            canvasLanguage7.SetActive(true);
        } else { 
            canvasLanguage7.SetActive(false);
        }
    }
}
