using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour
{
    public static int car;
    public GameObject[] CarList;
    // Start is called before the first frame update
   
    public void FirstCar()
    {
        car=1;
        CarList[0].gameObject.SetActive(true);
        CarList[1].gameObject.SetActive(false);
        CarList[2].gameObject.SetActive(false);
    }
    public void SecondCar()
    {
        car=2;
        CarList[0].gameObject.SetActive(false);
        CarList[1].gameObject.SetActive(true);
        CarList[2].gameObject.SetActive(false);
    }
    public void ThirdCar()
    {
        car=3;
        CarList[0].gameObject.SetActive(false);
        CarList[1].gameObject.SetActive(false);
        CarList[2].gameObject.SetActive(true);
    }

}
