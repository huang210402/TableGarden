using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainControl : MonoBehaviour
{
    private bool showTerrain = true;

    public GameObject[] terrains;

    void Start()
    {
        terrains = GameObject.FindGameObjectsWithTag("Terrain");

        foreach (GameObject t in terrains)
        {
            Debug.Log(t);
        }
    }

    public void pressCounter()
    {
        showTerrain = !showTerrain;

        if (showTerrain)
        {
            foreach (GameObject t in terrains)
            {
                t.SetActive(true);
            }
            Debug.Log("Show Terrain");
        }
        if (!showTerrain)
        {
            foreach (GameObject t in terrains)
            {
                t.SetActive(false);
                Debug.Log("Hide Terrain");
            }
        }
    }
}
