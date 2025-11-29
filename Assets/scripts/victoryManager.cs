using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victoryManager : MonoBehaviour
{
    public static victoryManager Instance;
    [SerializeField] int ZombieAmount;


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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OneLess()
    {
        ZombieAmount -= 1;
        if(ZombieAmount == 0)
        {
            UIManager.Instance.victoria();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
