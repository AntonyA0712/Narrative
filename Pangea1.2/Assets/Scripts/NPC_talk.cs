using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_talk : MonoBehaviour
{
    public GameObject dialogFlowchart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerFace"))
        {
            Debug.Log("Player is in range");

            if(Input.GetKeyDown(KeyCode.E))
            {
                //Debug.Log("hi");
                dialogFlowchart.SetActive(true);
            }

        }
    }
}
