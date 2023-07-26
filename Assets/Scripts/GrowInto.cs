using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowInto : MonoBehaviour
{
    public GameObject treeGroup;
    private GameObject newTree;

    [SerializeField] private Transform _parent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            Vector3 midPos = (gameObject.transform.position + other.gameObject.transform.position) / 2;
            newTree = Instantiate(treeGroup, midPos + new Vector3(0, 0, 0.6f), gameObject.transform.rotation, _parent);

            Debug.Log("Collision Detected");
            Debug.Log(newTree);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            Destroy(newTree);
        }
    }

}
