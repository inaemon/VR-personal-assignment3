using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorAnimation : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // ECCPortal Collider에 진입시
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "RobotPlayer")
        {
            print("Trigger Enter");
            animator.SetInteger("Control", 1);
        }
    }

    // ECCPortal Collider에서 퇴장시
    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.name == "RobotPlayer")
        {
            print("Trigger Exit");
            animator.SetInteger("Control", 2);
        }
    }
}