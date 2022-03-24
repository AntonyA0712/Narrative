using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_talk : MonoBehaviour
{
    public GameObject dialogFlowchart;

    public GameObject icon;

    // Start is called before the first frame update
    void Start()
    {
        icon.SetActive(true);
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
                dialogFlowchart.SetActive(true);

                icon.SetActive(false);

                //GetComponentInChildren<MeshRenderer>().enabled = false;
                //foreach (Renderer r in GetComponentsInChildren<MeshRenderer>())
                //r.enabled = false;
            }
        }
    }
}
