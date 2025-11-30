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
    [SerializeField] GameObject pantallaTutorial;
    [SerializeField] GameObject avanzatxt;
    [SerializeField] GameObject retrocedetxt;
    [SerializeField] TextMeshProUGUI texto;
    [SerializeField] TextMeshProUGUI vidaTxt;
    [SerializeField] bool perdio;
    [SerializeField] bool tutorial;
    [SerializeField] int indiceActual;
    [SerializeField] int txtCantidad;
    [SerializeField] List<string> nombresTutoriales = new List<string>()
    {
        "",
        "", 
        "",
        "",
        "",
        "",
        "",
        ""
    };
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
        //Time.timeScale = 1;
        //noPerdio.SetActive(true);
        Time.timeScale = 0;
        pantallaPerdio.SetActive(false);
        pantallaVictoria.SetActive(false);
        pantallaTutorial.SetActive(true);
        avanzatxt.SetActive(true);
        retrocedetxt.SetActive(false);
        perdio = false;
        tutorial = true;
        indiceActual = 0;
        txtCantidad = 8;
        texto.text = nombresTutoriales[0];
    }
    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKeyDown(KeyCode.S) && tutorial == true)
        {
            Time.timeScale = 1;
            noPerdio.SetActive(true);
            pantallaTutorial.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.N) && tutorial == true && indiceActual != txtCantidad-1)
        {
            indiceActual += 1;
            texto.text = nombresTutoriales[indiceActual];
            Debug.Log(nombresTutoriales[indiceActual]);
            if(indiceActual == txtCantidad-1){
                avanzatxt.SetActive(false);
            } else if(indiceActual == 1){
                retrocedetxt.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.P) && tutorial == true && indiceActual != 0)
        {
            indiceActual -= 1;
            texto.text = nombresTutoriales[indiceActual];
            if(indiceActual == txtCantidad-2){
                avanzatxt.SetActive(true);
            } else if(indiceActual == 0){
                retrocedetxt.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Z) && perdio == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
