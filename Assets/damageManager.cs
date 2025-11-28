using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class damageManager : MonoBehaviour
{
    [SerializeField] Collider zombie1;
    [SerializeField] Collider zombie2;
    [SerializeField] int vida;
    [SerializeField] bool tocadoHacePoco;
    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        tocadoHacePoco = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other == zombie1 || other== zombie2)
        {
            if(!tocadoHacePoco){
                inmunidad();
                 vida -= 33;
                UIManager.Instance.updateVida(vida);        
                if(vida<=0)
                {
                    UIManager.Instance.derrota();
                }
            }
        }
    }
    private async void inmunidad()
    {
        
            tocadoHacePoco = true;
            await Task.Delay(2000);
            tocadoHacePoco = false;
   
    }
}
