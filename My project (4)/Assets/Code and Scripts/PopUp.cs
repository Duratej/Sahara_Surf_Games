using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour{
    public GameObject openClose;
    public void trigger() {
        if (openClose.activeInHierarchy == true) {
            openClose.SetActive(false);
        } else {
            openClose.SetActive(true);
        }
    }
}
