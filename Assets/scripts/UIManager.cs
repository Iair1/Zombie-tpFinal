using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] GameObject pantallaPerdio;
    [SerializeField] GameObject noPerdio;
    [SerializeField] GameObject pantallaVictoria;
    [SerializeField] TextMeshProUGUI vidaTxt;
    [SerializeField] bool perdio;
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
    public void muestraAgarraPistola(bool ToF, GameObject interraccion) //los objetos de estas funciones aparecen en activator.cs
    {
        interraccion.SetActive(ToF);
    }
    public void updateVida(int vida){
        vidaTxt.text = $"Vida: {vida}";
    }
    public void derrota(){
        Time.timeScale = 0;
        noPerdio.SetActive(false);
        pantallaPerdio.SetActive(true);
        perdio = true;
    }
    public void victoria(){
        Time.timeScale = 0;
        noPerdio.SetActive(false);
        pantallaVictoria.SetActive(true);
        perdio = true;
    }

    void Start()
    {
        Time.timeScale = 1;
        noPerdio.SetActive(true);
        pantallaPerdio.SetActive(false);
        pantallaVictoria.SetActive(false);
        perdio = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && perdio == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
