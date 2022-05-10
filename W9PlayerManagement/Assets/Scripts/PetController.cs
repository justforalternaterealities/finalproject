using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    int petCount = 0;
    bool canPet = true;
    int isCalmHash;

    private void Awake()
    {
        isCalmHash = Animator.StringToHash("isCalm");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hand"))
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 v3Velocity = rb.velocity;

            if (petCount >= 3)
            {
                Animator animator = GetComponentInParent<Animator>();
                animator.SetBool(isCalmHash, true);
                //print("now calm");
            }

            if (canPet && v3Velocity.magnitude < 1) petCount += 1;
            canPet = false;
            //print(petCount);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("hand"))
        {
            canPet = true;
            //animator.SetBool(isAttackingHash, false);
        }
    }
}
