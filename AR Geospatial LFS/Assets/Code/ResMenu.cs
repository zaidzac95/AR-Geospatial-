using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResMenu : MonoBehaviour
{
    public RectTransform panelR;
    public RectTransform panelRe;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMenu()
    {
        LeanTween.moveX(panelR, 0, 0.5f).setEaseInQuad();
        LeanTween.moveX(panelRe, 1038, 0.5f).setEaseInQuad();
    }
    public void OnReview()
    {
        LeanTween.moveX(panelR, -1038, 0.5f).setEaseInQuad();
        LeanTween.moveX(panelRe,0, 0.5f).setEaseOutQuad();
    }

}
