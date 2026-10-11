using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectTrophy : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public static int coin;
    void Start()
    {
       coin=PlayerPrefs.GetInt("coin");
       scoreText.text = "x  " + coin.ToString();
    }

    public void OnTriggerEnter(Collider other) {
        
  
            if(other.gameObject.tag == "Car")
            {
                coin = coin + 1 ; 
                scoreText.text = "x  " + coin.ToString();
                PlayerPrefs.SetInt("coin",coin);
                Destroy(gameObject);
                
            }

    }



    
    void Update()
    {
       
    }
}
