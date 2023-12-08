using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiftObject : MonoBehaviour
{
    private Transform gripPoint;

    public GameObject triggerText;

    private bool canCarry = false;
    private bool isCarried = false;




    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            gripPoint = other.transform.GetChild(1);
            canCarry = true;
            triggerText.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            canCarry = true;
            triggerText.SetActive(true);
            Debug.Log("not being carried");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        { 
            canCarry = false;
            triggerText.SetActive(false);
            Debug.Log("not being carried");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && canCarry)
        {   
            GetComponent<AudioSource>().Play();

            if (!isCarried) 
            { 
                isCarried = true;
                transform.position = gripPoint.position;
                transform.rotation = gripPoint.rotation;
                transform.parent = gripPoint;
                GetComponent<Rigidbody>().isKinematic = true;
                GetComponent <Collider>().isTrigger = true;

            }

            else 
            {
                transform.parent = null;
                GetComponent<Rigidbody>().isKinematic = false;
                GetComponent<Collider >().isTrigger = false;
                isCarried = false;
                GetComponent<Rigidbody>().useGravity = true;
                
            }

            if (isCarried == true)
            {
                triggerText.SetActive(false);
            }

        }

    }
}
