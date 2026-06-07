using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Cambio : MonoBehaviour
{
    [SerializeField] public GameObject canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    private bool isPaused = false;
    public void Awake()
    {
        canvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) Seguir();
            else Pausa();
        }

    }
    public void Pausa()
    {
        isPaused = true;
        canvas.SetActive(true);
        Time.timeScale = 0f;              
        Cursor.lockState = CursorLockMode.None;  
        Cursor.visible = true;

    }
    public void Seguir()
    {
        isPaused = false;
        canvas.SetActive(false);
        Time.timeScale = 1f;        
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;

    }
    public void Escena1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel1");
    }
    public void Escena2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel2");
    }
    public void Escena3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel3");
    }
}
