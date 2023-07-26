using UnityEngine;
using UnityEngine.UI;

public class BlinkBehaviour : MonoBehaviour
{
    public float speed;

    private CanvasGroup myUICanvas;

    private void Awake()
    {
        myUICanvas = GetComponent<CanvasGroup>();
    }


    // Update is called once per frame
    void Update()
    {
        myUICanvas.alpha = Mathf.Lerp(1.0f, 0f, Mathf.PingPong(Time.time * speed, 1));
    }
}
