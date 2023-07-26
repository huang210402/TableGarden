using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TapBehaviour : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGrouop;
    [SerializeField] private GameObject title;
    [SerializeField] private Transform moveUp;

    [SerializeField] private GameObject tapText;
    [SerializeField] private GameObject pickText;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;

    private bool fadeIn = false;

    public void ShowUI()
    {
        fadeIn = true;
        title.transform.DOJump(moveUp.position, 1.0f, 1, 1);
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (myUIGrouop.alpha < 1)
            {
                myUIGrouop.alpha += Time.deltaTime;
                if(myUIGrouop.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }

        if(Input.touchCount > 0)
        {
            ShowUI();
            tapText.SetActive(false);
            pickText.SetActive(true);
            button1.SetActive(true);
            button2.SetActive(true);
        }
    }


}
