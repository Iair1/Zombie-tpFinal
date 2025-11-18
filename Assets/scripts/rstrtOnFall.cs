using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rstrtOnFall : MonoBehaviour
{
    public float yFakkHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yFakkHeight)
        {
            Debug.Log("JAJA te caíste");
            SceneManager.LoadScene("parkour");
        }
    }
}
