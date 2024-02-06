using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public movimentPlayer Player;
    public TextMeshProUGUI marcadorVides;

    public MovimentsEnemic1 Enemic1;
    public TextMeshProUGUI marcadorScore;

    public TextMeshProUGUI puntuacioActual;
    public TextMeshProUGUI puntuacioRecord;
    public GameObject PantallaFinal;


    public GameObject MenuPause;


    private int puntuacio;

    // Start is called before the first frame update
    void Start()
    {
        puntuacio = 0;
    }

    // Update is called once per frame
    void Update()
    {
        marcadorVides.text = " " + Player.Vides();
        marcadorScore.text = " " + DonarPunts();

        if ((Player.Vides() == 0) && (PantallaFinal.activeSelf == false))
        {

            PantallaFinal.SetActive(true);
            puntuacioActual.text = puntuacio.ToString();
            if (PlayerPrefs.GetInt("Record") < puntuacio)
            {
                PlayerPrefs.SetInt("Record", puntuacio);
            }
            puntuacioRecord.text = PlayerPrefs.GetInt("Record").ToString();
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausarJoc();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && (MenuPause.activeSelf == true))
        {
            ResumirJoc();
        }
    }
    public void sumaScore(int punts)
    {
        puntuacio = puntuacio + punts;
        Debug.Log("Puntuación actualitzada: " + puntuacio);

    }
    public int DonarPunts()
    {
        return puntuacio;
        Debug.Log("Puntuación consultada: " + puntuacio);
    }
    public void TornarJugar()
    {
        SceneManager.LoadScene("EraySlasher");
    }
    public void Sortir()
    {
        UnityEngine.Application.Quit();
    }
    public void PausarJoc()
    {
        SceneManager.LoadScene("MenuPausa");
        Time.timeScale = 0f;
        MenuPause.SetActive(true);

    }
    public void ResumirJoc()
    {
        Time.timeScale = 1f;
        MenuPause.SetActive(false);

    }
    public void ReiniciarJoc()
    {
        SceneManager.LoadScene("EraySlasher");
    }
    
}
