using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public GameObject panelStart;
    public GameObject panelConvo;

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void StartGame()
    { 
        panelStart.SetActive(false);
        panelConvo.SetActive(true);
    }
    
}
