using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogController : MonoBehaviour
{
    Animator animator;
    NavMeshAgent agent;

    int isWalkingHash;
    int velocityXHash;
    int velocityZHash;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        isWalkingHash = Animator.StringToHash("isWalking");
        velocityXHash = Animator.StringToHash("velocityX");
        velocityZHash = Animator.StringToHash("velocityZ");
    }

    // Update is called once per frame
    void Update() {
        //animator.SetBool("isWalking", true);
        //transform.position += transform.forward * Time.deltaTime;
        Vector3 velocity = agent.velocity;

        agent.SetDestination(Camera.main.transform.position);
        bool isMoving = velocity.magnitude > 0.01f && agent.remainingDistance > agent.radius;

        velocity = transform.InverseTransformVector(velocity);

        animator.SetBool(isWalkingHash, isMoving);
        animator.SetFloat(velocityXHash, velocity.x);
        animator.SetFloat(velocityZHash, velocity.z);
    }
}
