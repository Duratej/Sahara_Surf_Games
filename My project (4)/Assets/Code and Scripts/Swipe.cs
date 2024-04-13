using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public Image pageImage;
    public List<Sprite> numbers;
    public int pageNumber;

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    private void Update() {
        //recording where user started touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            startTouchPosition = Input.GetTouch(0).position;
        }
        //recording where user ended touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            endTouchPosition=Input.GetTouch(0).position;
            //if where they ended is further left than where they started, swipe left and vise versa
            if (endTouchPosition.x < startTouchPosition.x) {
                NextPage();
            }
            if (endTouchPosition.x > startTouchPosition.x) {
                PrevPage();
            }
        }
    }
    private void PrevPage() {
        if (pageNumber > 0) {
            pageNumber--;
        }
        pageImage.sprite = numbers[pageNumber];
        Debug.Log(pageNumber);
    }
    private void NextPage() {
        if (pageNumber < 4) {
            pageNumber++;
        }
        pageImage.sprite = numbers[pageNumber];
        Debug.Log(pageNumber);
    }
    public void setPageNumber(int num) {
        pageNumber = num;
        pageImage.sprite = numbers[pageNumber];
        Debug.Log(pageNumber);
    }
}
