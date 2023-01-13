using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flippers : MonoBehaviour
{
    [SerializeField] 
    float restPosition;

    [SerializeField] 
    float flippedPosition;

    [SerializeField] 
    float springForce = 20000f;

    [SerializeField] 
    float flipperDamper = 150f;

    public string inputName;
    HingeJoint hinge;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        JointSpring spring = new JointSpring();
        spring.spring = springForce;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = flippedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
