using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] GameObject cosoDeLaE;
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
    public void muestraAgarraPistola(bool ToF)
    {
        cosoDeLaE.SetActive(ToF);
    }

    void Start()
    {
        cosoDeLaE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
