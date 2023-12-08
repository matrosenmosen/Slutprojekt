using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton: MonoBehaviour
{
    public GameObject pausePanel;

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.P)) 
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }

    }

    public void Continue()
    { 
       Time.timeScale = 1;
       pausePanel.SetActive(false);
    }

    
}
