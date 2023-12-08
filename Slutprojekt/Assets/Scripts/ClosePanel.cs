using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelConvo;

    public void Close() 
    {
        panel.SetActive(false);
        panelConvo.SetActive(true);
        Time.timeScale = 1f;
    }


}
