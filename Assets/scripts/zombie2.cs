using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie2 : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] int vidaZ;
    [SerializeField] Transform bala;
    [SerializeField] Transform player;
    [SerializeField] 


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        //player = FindObjectOfType<CharacterController>().GetComponent<Transform>();
        player = GameObject.Find("SimpleFPSController").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        vidaZ = 100;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.position;
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("bala"))
        {
            vidaZ -= 33;
            Destroy(other.gameObject);
            if(vidaZ<=0)
            {
                victoryManager.Instance.OneLess();
                Destroy(gameObject);
            }
        }
    }
}
