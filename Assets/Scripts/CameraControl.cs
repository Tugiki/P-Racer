using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Car;
    public float speed;
    public GameObject child;
    void Start()
    {
        Car = GameObject.FindGameObjectWithTag("Car");
        child = Car.transform.Find("Camera").gameObject;
    }

    private void FixedUpdate(){
        camera_Follow();
    }

    // Update is called once per frame
    private void camera_Follow(){

        gameObject.transform.position = Vector3.Lerp(transform.position,child.transform.position,Time.deltaTime * speed);
        gameObject.transform.LookAt(Car.gameObject.transform.position);

    }
}
