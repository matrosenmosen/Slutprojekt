using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenes : MonoBehaviour
{
  // Avslutar spelet och laddar om scenen
    public void ReloadScene() 
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame() 
    { 
        Application.Quit();
        Debug.Log("Quit game");
    }

 
}
