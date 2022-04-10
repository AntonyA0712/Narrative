using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_talk_auto : MonoBehaviour
{
    public GameObject dialogFlowchart;
    public MeshRenderer mesh;
    public Collider trigger;

    public GameObject icon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerFace"))
        {
            Debug.Log("Player is in range");

            dialogFlowchart.SetActive(true);
        }
    }
    public void CarrotCollected()
    {   
        
        GetComponent<Collider>().enabled = false;
        mesh.enabled = false;
        trigger.enabled = false;
        //this.gameObject.SetActive(false);
        Debug.Log("carrot");
    }

    public void icon_display()
    {
       icon.SetActive(false);
    }

        
    


}
