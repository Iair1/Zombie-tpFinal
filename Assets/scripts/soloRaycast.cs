using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soloRaycast : MonoBehaviour
{
    public static soloRaycast Instance;
    
    [SerializeField] Collider a;
    // Start is called before the first frame update
    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    public Collider raycast()
    {
        Debug.Log("iniciado");
        Vector3 adelante = transform.TransformDirection(Vector3.forward);
        adelante.y = 1f;
        adelante.Normalize();
        if(Physics.Raycast(transform.position, adelante, out RaycastHit hit)){
            Debug.Log(hit);
            return(hit.collider);
            
        }
        Debug.Log("No encontre nada");
        return(a);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
