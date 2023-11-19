using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnim : MonoBehaviour
{
    public RectTransform panelRT;
    public RectTransform panelRT2;
    public RectTransform panelRT3;
    public RectTransform panelRT4;
    public RectTransform panelRT5;
    public RectTransform panelRT6;
    public RectTransform panelRT7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnShowRes1()
    {
        LeanTween.moveX(panelRT, 0, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT2, 0, 0.8f).setEaseInQuad();
    }
    public void OnShowRes2()
    {
        LeanTween.moveX(panelRT, 0, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT7, 0, 0.8f).setEaseInQuad();
    }
    public void OnDiscount1()
    {
        LeanTween.moveX(panelRT2, -2201, 0.5f).setEaseInQuad();
        LeanTween.moveX(panelRT4, 0, 0.8f).setEaseOutQuad();
    }
    public void OnDiscount2()
    {
        LeanTween.moveX(panelRT7, -2201, 0.5f).setEaseInQuad();
        LeanTween.moveX(panelRT4, 0, 0.8f).setEaseOutQuad();
    }
    public void OnHideDiscount1()
    {
        LeanTween.moveX(panelRT2, 0, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT4, -1199, 0.8f).setEaseOutQuad();
    }
    public void OnHideDiscount2()
    {
        LeanTween.moveX(panelRT7, 0, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT4, -1199, 0.8f).setEaseOutQuad();
    }
    public void OnNavigation1()
    {
        LeanTween.moveX(panelRT, 1125, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT2, -2201, 0.8f).setEaseInQuad();
    }
    public void OnNavigation2()
    {
        LeanTween.moveX(panelRT, 1125, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT7, -2201, 0.8f).setEaseInQuad();
    }
    public void OnMainMenu1()
    {
        LeanTween.moveX(panelRT2, -2201, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT3, 0, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT5, 0, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT6, -1301, 0.8f).setEaseInQuad();
    }
    public void OnMainMenu2()
    {
        LeanTween.moveX(panelRT7, -2201, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT3, 0, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT5, 0, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT6, -1301, 0.8f).setEaseInQuad();
    }
    public void OnRes1()
    {
        LeanTween.moveX(panelRT2, 0, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT3, 1450, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT5, 300, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT6, -1820, 0.8f).setEaseInQuad();

    }
    public void OnRes2()
    {
        LeanTween.moveX(panelRT7, 0, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT3, 1450, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT5, 300, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT6, -1820, 0.8f).setEaseInQuad();

    }
    public void OnCamera()
    {
        LeanTween.moveX(panelRT, 1125, 0.8f).setEaseInQuad();
        LeanTween.moveX(panelRT3, 1450, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT5, 300, 0.8f).setEaseInQuad();
        LeanTween.moveY(panelRT6, -1820, 0.8f).setEaseInQuad();

    }
}
