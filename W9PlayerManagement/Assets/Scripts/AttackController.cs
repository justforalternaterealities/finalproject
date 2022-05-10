using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    int isAttackingHash;

    private void Awake()
    {
        isAttackingHash = Animator.StringToHash("isAttacking");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("dog"))
        {
            Animator animator = other.gameObject.GetComponentInParent<Animator>();
            animator.SetBool(isAttackingHash, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("dog"))
        {
            Animator animator = other.gameObject.GetComponentInParent<Animator>();
            //animator.SetBool(isAttackingHash, false);
        }
    }
}
