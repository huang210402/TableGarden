using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public float duration;
    float timeElapsed = 0;

    private CanvasGroup myUICanvas;

    private void Awake()
    {
        myUICanvas = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        myUICanvas.alpha = Mathf.Lerp(0f, 1.0f, timeElapsed / duration);
        timeElapsed += Time.deltaTime;
    }
}
