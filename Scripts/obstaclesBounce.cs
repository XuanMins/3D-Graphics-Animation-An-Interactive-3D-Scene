using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesBounce : MonoBehaviour
{
    public float bounceForce = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        pinBall pinBall = collision.transform.GetComponent<pinBall>();

        Debug.Log("Hit: " + pinBall);

        if (pinBall)
        {
            pinBall.rb.AddForce((collision.contacts[0].normal * bounceForce), ForceMode.VelocityChange);
        }
    }
}
