using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Fungus;

// Part of this code was used from https://www.youtube.com/watch?v=CIJtpkN_e8A
// Part of this code was used from https://www.youtube.com/watch?v=lkGPLsQztrE

public class CharacterMovement : MonoBehaviour
{
    public Camera camera;
    private RaycastHit hit;
    private NavMeshAgent agent;
    private string groundTag = "Ground";
    public Flowchart myFlowchart;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Click on the GROUND to move.
        if (Input.GetMouseButtonDown(0)) // 0 is left click, 1 is right click, 2 is middle mouse button down.
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag(groundTag))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }

    // If the player walks into an NPC collider, it starts the corresponding dialogue.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Susan")
        {
            myFlowchart.ExecuteBlock("Susan");
        }

        if (other.gameObject.tag == "Barold")
        {
            myFlowchart.ExecuteBlock("Barold");
        }

        if (other.gameObject.tag == "Jimothy")
        {
            myFlowchart.ExecuteBlock("Jimothy");
        }

        if (other.gameObject.tag == "Courtney")
        {
            myFlowchart.ExecuteBlock("Courtney");
        }

        if (other.gameObject.tag == "Flower")
        {
            myFlowchart.ExecuteBlock("PickedFlower");
        }

        if (other.gameObject.tag == "Bug")
        {
            myFlowchart.ExecuteBlock("CollectedBug");
        }

        if (other.gameObject.tag == "Mushroom")
        {
            myFlowchart.ExecuteBlock("CollectedMushroom");
        }

        if (other.gameObject.tag == "Dirt")
        {
            myFlowchart.ExecuteBlock("CollectedDirt");
        }
    }
}