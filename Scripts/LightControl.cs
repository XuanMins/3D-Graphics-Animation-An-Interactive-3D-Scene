using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    GameObject[] sidelights;

    // Start is called before the first frame update
    void Start()
    {
        sidelights = GameObject.FindGameObjectsWithTag("sidelights");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RandomLights()
    {
        foreach (GameObject go in sidelights)
        {
            go.GetComponentInChildren<Light>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        }
    }
}
