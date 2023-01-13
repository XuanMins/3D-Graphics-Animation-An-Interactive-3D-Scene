using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugDirectionDrawer : MonoBehaviour
{
    public float length = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * length));
    }
}
