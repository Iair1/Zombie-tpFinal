using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public moneyManager moneyManager;
    void Start()
    {
        moneyManager = FindObjectOfType<moneyManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            if(moneyManager.UpdateMoney(-precio) == true) { 
            Destroy(gameObject);
            }
        }
    }
}
