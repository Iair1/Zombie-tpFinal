using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{
    [SerializeField] GameObject pistolaEnMano;
    [SerializeField] GameObject pistolaEnSuelo;
    [SerializeField] GameObject barreraInvisible;
    [SerializeField] bool tocando = false;

    [SerializeField] GameObject cosoDelaE;
    [SerializeField] GameObject aunNo;
    [SerializeField] GameObject tocandoActual;
    // Start is called before the first frame update
    void Start()
    {
        pistolaEnMano.SetActive(false);
        UIManager.Instance.muestraAgarraPistola(false, cosoDelaE);
        UIManager.Instance.muestraAgarraPistola(false, aunNo);

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && tocando)
        {
            Destroy(pistolaEnSuelo);
            Destroy(barreraInvisible);
            pistolaEnMano.SetActive(true);
            UIManager.Instance.muestraAgarraPistola(false, cosoDelaE);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if(other.gameObject== pistolaEnSuelo)
        {
            UIManager.Instance.muestraAgarraPistola(true, cosoDelaE);
            tocandoActual = cosoDelaE;
            tocando = true;
        } else if(other.gameObject == barreraInvisible)
        {
            UIManager.Instance.muestraAgarraPistola(true, aunNo);
            tocandoActual = aunNo;
        }
    }    
    void OnTriggerExit(Collider other)
    {
        if(tocandoActual)
        {
        UIManager.Instance.muestraAgarraPistola(false, tocandoActual);
        }
        tocandoActual = null;
        tocando = false;
    }
}
