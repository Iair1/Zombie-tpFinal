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
    public void muestraAgarraPistola()
    {
        cosoDeLaE.SetActive(true);
    }
    public void noMuestraAgarraPistola()
    {
        cosoDeLaE.SetActive(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
