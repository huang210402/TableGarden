using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpawnScale : MonoBehaviour
{

    private void Start()
    {
        if (gameObject.CompareTag("Tree"))
        {
            gameObject.transform.DOScale(new Vector3(0.3f, 0.3f, 0.3f), 1);
        }
        if (gameObject.CompareTag("PineTree"))
        {
            gameObject.transform.DOScale(new Vector3(0.17f, 0.17f, 0.17f), 1);
        }
        else if (gameObject.CompareTag("Groundcover"))
        {
            gameObject.transform.DOScale(new Vector3(1, 1, 1), 1);
        }
    }

}
