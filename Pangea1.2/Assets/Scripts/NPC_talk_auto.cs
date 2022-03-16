using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_talk_auto : MonoBehaviour
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
        if (other.CompareTag("PlayerFace"))
        {
            Debug.Log("Player is in range");

            dialogFlowchart.SetActive(true);
        }
    }
    public void CarrotCollected()
    {
        GetComponentInChildren<MeshRenderer>().enabled = false;
        Debug.Log("carrot");
    }
}
