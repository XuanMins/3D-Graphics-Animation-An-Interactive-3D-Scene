using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    
    [Header("Pin Ball")]
    public pinBall pinBallPrefab;
    public Transform pinBallSpawnPoint;
    public float maxForce = 40f;

    [Header("Board")]

    public Transform board;

    public Vector3 rotation;

    public LightControl lc;

    void Awake()
    {
        board.rotation = Quaternion.Euler(rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(pinBallPrefab + " is dispensed.");
            ShootBall();
        }
    }

    void ShootBall()
    {
        pinBall pinBall = Instantiate(pinBallPrefab, pinBallSpawnPoint.position, pinBallSpawnPoint.rotation);
        pinBall.rb.AddForce((pinBallSpawnPoint.forward * maxForce), ForceMode.VelocityChange);
        lc.RandomLights();
    }

}
    