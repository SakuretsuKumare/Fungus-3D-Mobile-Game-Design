using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// This code was used from https://www.youtube.com/watch?v=CIJtpkN_e8A

public class CharacterMovement : MonoBehaviour
{
    public Camera camera;
    private RaycastHit hit;
    private NavMeshAgent agent;
    private string groundTag = "Ground";

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 is left click, 1 is right click, 2 is middle mouse button.
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
}