using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//el dinero del jugador es manejado diretamente por el moneyManager
public class UImanager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI salud;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateHealthText(string vida)
    {
        //Debug.Log("YANANANANNANANANA");
        salud.text = $"HP: {vida}";
    }
}
