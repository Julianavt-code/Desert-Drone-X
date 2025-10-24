using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Buttons : MonoBehaviour
{

    public GameObject InstruccionesPanel;

 public GameObject CreditsPanel;

    public GameObject SettingsPanel;

    public GameObject PausePanel;

    public bool IsPaused = false;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;        
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;        
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CreditsOn()
    {
        CreditsPanel.SetActive(true);
    }

    public void CreditsOff()
    {
        CreditsPanel.SetActive(false);
    }

     public void InstruccionesOff()
    {
        InstruccionesPanel.SetActive(false);
    }

     public void SettingsOn()
    {
        SettingsPanel.SetActive(true);
    }

    public void SettingsOff()
    {
        SettingsPanel.SetActive(false);
    }

    public void PauseOn()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void PauseOff()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
