using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string MapHolder;

    public void Career()
    {
       SceneManager.LoadScene("Game");
       CarSelect.car = 1;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(MapHolder);

    }
   
    public void FirstMap()
    {
        MapHolder = "Game";
    }
    public void SecondMap()
    {
        MapHolder = "Game2";
    }
    public void ThirdMap()
    {
        MapHolder = "Game3";
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
