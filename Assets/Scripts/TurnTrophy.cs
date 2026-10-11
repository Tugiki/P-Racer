using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrophy : MonoBehaviour
{

        void Update ()
    {
        
        transform.Rotate (0,125*Time.deltaTime,0);
    }
}
