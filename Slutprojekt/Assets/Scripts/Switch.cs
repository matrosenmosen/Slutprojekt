using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    // Slideshow script



    // refererar till index
    public GameObject[] panels;
    int index;
    public int pages;

    void Start()
    {
        index = 0;
    }

    private void Update()
    {
        // 


        if (index >= pages)
        {
            index = pages;
        }

        else if (index < 0)
        {
            index = 0;
        }

        else if (index == 0)
        {
            panels[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {

        //Bläddrar framåt

        index++;

        for (int i = 0; i < panels.Length; i++)
        {
            if (index > panels.Length - 1)
            {
                index = 0;
            }

            panels[i].gameObject.SetActive(false);
            panels[index].gameObject.SetActive(true);
        }

        Debug.Log("next");
    }
    public void Previous()
    {

        // Bläddrar bakåt

        index--;

        for (int i = 0; i < panels.Length; i++)
        {

            if (index < 0)
            {
                index = panels.Length - 1;
            }

            panels[i].gameObject.SetActive(false);
            panels[index].gameObject.SetActive(true);
        }

        Debug.Log("previous");
    }

}