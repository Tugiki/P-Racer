using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spawn : MonoBehaviour
{   
    public GameObject[] CarList;
    
    void Start()
    {
       if(CarSelect.car == 1)
       {
        CarList[0].gameObject.SetActive(true);
        CarList[1].gameObject.SetActive(false);
        CarList[2].gameObject.SetActive(false);
       }
       else if(CarSelect.car == 2)
       {
        CarList[1].gameObject.SetActive(true);
        CarList[0].gameObject.SetActive(false);
        CarList[2].gameObject.SetActive(false);
       }
       else if(CarSelect.car == 3)
       {
        CarList[1].gameObject.SetActive(false);
        CarList[0].gameObject.SetActive(false);
        CarList[2].gameObject.SetActive(true);
       }
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
