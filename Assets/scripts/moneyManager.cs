using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class moneyManager : MonoBehaviour
{
    public float money;
    public TextMeshProUGUI dinero;
     void Start()
    {
        dinero.text = $"Tienes ${money}.";
    }
    public bool UpdateMoney(float amount)
    {
        if(money+amount < 0)
        {
            Debug.Log("No alcanza el dinero");
            return false;
        }else
        {
            money += amount;
            dinero.text = $"Tienes ${money}.";
            return true;
        }
    }
}