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
    public MovimentsEnemic2 Enemic2;

    public TextMeshProUGUI marcadorScore;
    public TextMeshProUGUI marcadorScore2;


    public TextMeshProUGUI puntuacioActual;
    public TextMeshProUGUI puntuacioRecord;
    public GameObject PantallaFinal;


    public GameObject MenuPause;


    private int puntuacio;
    private int puntuacioE2;

    // Start is called before the first frame update
    void Start()
    {
        puntuacio = 0;
        puntuacioE2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        marcadorVides.text = " " + Player.Vides();
        marcadorScore.text = " " + DonarPunts();
        marcadorScore2.text = " " + ScoreEnemic2();

        if ((Player.Vides() <= 1) && (PantallaFinal.activeSelf == false))
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
    }
    public void sumaScoreEnemic2(int puntsEnemic2)
    {
        puntuacioE2 = puntuacioE2 + puntsEnemic2;

    }
    public int ScoreEnemic2()
    {
        return puntuacioE2;
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
