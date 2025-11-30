using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneador : MonoBehaviour
{
    [SerializeField] GameObject Zombies;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Zombies.SetActive(false);
        player = GameObject.Find("SimpleFPSController"); 
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            Zombies.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
