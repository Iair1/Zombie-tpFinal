using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{
    [SerializeField] GameObject pistolaEnMano;
    [SerializeField] GameObject pistolaEnSuelo;
    // Start is called before the first frame update
    void Start()
    {
        pistolaEnMano.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        
        if(other.transform = pistolaEnSuelo)
        {
            UIManager.muestraAgarraPistola();
        }
    }
}
