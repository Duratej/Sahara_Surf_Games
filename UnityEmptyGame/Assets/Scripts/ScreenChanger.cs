using UnityEngine;

public class ScreenChanger : MonoBehaviour {

    public static int ScreenNumber;

    public GameObject IntroScreen1;
    public GameObject MainMenuScreen2;
    public GameObject GameScreen3;
    public GameObject MapScreen4;
    public GameObject QuestScreen5;

    void Start() {
        ScreenNumber = 1;
    }

    public void ScreenSwap(int newNum) {

        ScreenNumber = newNum;

        if (ScreenNumber == 1) {
            IntroScreen1.SetActive(true);
        }   else {
            IntroScreen1.SetActive(false);
        }
        if (ScreenNumber == 2) {
            MainMenuScreen2.SetActive(true);
        } else { 
            MainMenuScreen2.SetActive(false);
        }
        if (ScreenNumber == 3) {
            GameScreen3.SetActive(true);
        } else { 
            GameScreen3.SetActive(false);
        }
        if (ScreenNumber == 4) {
            MapScreen4.SetActive(true);
        } else { 
            MapScreen4.SetActive(false);
        }
        if (ScreenNumber == 5) {
            QuestScreen5.SetActive(true);
        } else { 
            QuestScreen5.SetActive(false);
        }
    }
}
