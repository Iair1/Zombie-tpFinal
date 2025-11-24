using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieHealthAndEnemyManager : MonoBehaviour
{
    [SerializeField] int vidaZ;
    [SerializeField] Transform bala;

    // Start is called before the first frame update
    void Start()
    {
        vidaZ = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("bala"))
        {
            vidaZ -= 33;
            Destroy(other.gameObject);
            if(vidaZ<=0)
            {
                Destroy(gameObject);
            }
        }
    }
}
