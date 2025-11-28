using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageManager : MonoBehaviour
{
    [SerializeField] Collider zombie1;
    [SerializeField] Collider zombie2;
    [SerializeField] int vida;
    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(zombie1);
        if(other == zombie1 || other== zombie2)
        {
            vida -= 33;
            UIManager.Instance.updateVida(vida);
            if(vida<=0)
            {
                UIManager.Instance.derrota();
            }
        }
    }
}
