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
    [SerializeField] GameObject cosoRaycast;
    [SerializeField] int targetAmount;
    [SerializeField] int trgtNumber;
    [SerializeField] string nombreRecorrido;

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
       currentTargetTR = GameObject.Find($"ZombieRecorrido{nombreRecorrido}{trgtNumber}").transform;
       chaseMode = false;
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
            
            if (((agent.nextPosition - agent.destination).x + (agent.nextPosition - agent.destination).z) == 0)
            {
                trgtNumber = trgtNumber + 1;
                trgtNumber = trgtNumber % targetAmount;
                currentTargetTR = GameObject.Find($"ZombieRecorrido{nombreRecorrido}{trgtNumber}").transform;

            }

            
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit)){
                if(hit.collider.transform == player)
                {
                    chaseMode = true;
                    currentTargetTR=player;
                }
            }
            
        }
        agent.destination = currentTargetTR.position;
        velocity = agent.velocity.magnitude;
        anim.SetFloat("Speed",velocity);
    }
}
