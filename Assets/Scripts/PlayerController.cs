using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] WheelCollider right_Front;
    [SerializeField] WheelCollider left_Front;
    [SerializeField] WheelCollider right_Back;
    [SerializeField] WheelCollider left_Back;

    public float acceleration = 500f;
    public float breakingForce=300f;
    public float turn_Angle = 15f;

    private float currentAccel = 0f;
    private float currentBreak = 0f;
    private float currentTurn = 0f;
    private float centermass = -0.9f;
     private void Start() {

        GetComponent<Rigidbody>().centerOfMass = new Vector3(0,centermass,0);
        
    }

    private void FixedUpdate() {
        
        currentAccel = acceleration * Input.GetAxis("Vertical");


        if(Input.GetKey(KeyCode.Space))
            currentBreak = breakingForce;
        else 
            currentBreak = 0f;

    right_Front.motorTorque = currentAccel;
    left_Front.motorTorque = currentAccel;

    right_Front.brakeTorque = currentBreak;
    left_Front.brakeTorque = currentBreak;
    left_Back.brakeTorque = currentBreak;
    right_Back.brakeTorque = currentBreak;

    currentTurn = turn_Angle* Input.GetAxis("Horizontal");
    left_Front.steerAngle = currentTurn;
    right_Front.steerAngle = currentTurn;


    }
 
}
