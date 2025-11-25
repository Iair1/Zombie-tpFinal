using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    
    NavMeshAgent agent;
    public Transform[] targetsTR;
    [SerializeField] Transform currentTargetTR;
    [SerializeField] Animator anim;
    [SerializeField] float velocity;
    [SerializeField] float arrivalDistance;
    [SerializeField] float distanceToPlayer;
    [SerializeField] Transform player;
    [SerializeField] bool chaseMode;

    int currentTarget = 0;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        //player = FindObjectOfType<CharacterController>().GetComponent<Transform>();
        player = GameObject.Find("SimpleFPSController").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
       chaseMode = false;
       anim.SetBool("loVe", false);
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position,player.position);

        if (chaseMode)
        {
            currentTargetTR = player;

        }else 
        {

            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit))
            {
                Debug.Log(hit.collider.name);
                currentTargetTR = this.transform;
            }
        }
        agent.destination = currentTargetTR.position;
        velocity = agent.velocity.magnitude;
        anim.SetFloat("Speed",velocity);
    }
}
