using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageManager : MonoBehaviour
{
    public int damagePoints;
    public healthManager healthManager;
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<healthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Debug.Log("pinchos chocaron");
            healthManager.UpdateHealth(-damagePoints);
        }
    }
}
