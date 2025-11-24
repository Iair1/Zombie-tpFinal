using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{
    [SerializeField] GameObject pistolaEnMano;
    [SerializeField] GameObject pistolaEnSuelo;
    [SerializeField] bool tocando = false;
    // Start is called before the first frame update
    void Start()
    {
        pistolaEnMano.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && tocando)
        {
            Destroy(pistolaEnSuelo);
            pistolaEnMano.SetActive(true);
            UIManager.Instance.muestraAgarraPistola(false);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject== pistolaEnSuelo)
        {
            UIManager.Instance.muestraAgarraPistola(true);
            tocando = true;
        }
    }    
    void OnTriggerExit(Collider other)
    {
        UIManager.Instance.muestraAgarraPistola(false);
        tocando = false;
    }
}
