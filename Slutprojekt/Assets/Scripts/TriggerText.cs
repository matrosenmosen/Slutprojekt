using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    
    // script som kan setactive gameobjects genom trigger
    
    public GameObject triggerText;
    public GameObject panel;

    private bool canread = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerText.SetActive(true);
            canread = true;
            
}
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerText.SetActive(true);
            canread = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerText.SetActive(false);
            canread = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canread)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;

        }

    }
}
