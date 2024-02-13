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

    public MovimentsEnemic1 Enemic1;
    public MovimentsEnemic2 Enemic2;

    public TextMeshProUGUI marcadorScore;
    public TextMeshProUGUI marcadorScore2;


    public TextMeshProUGUI puntuacioActual;
    public TextMeshProUGUI puntuacioRecord;
    public GameObject gameOver;

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
        marcadorScore.text = " " + DonarPunts();
        marcadorScore2.text = " " + ScoreEnemic2();

        if ((Player.Vides() <= 1) && (gameOver.activeSelf == false))
        {
            gameOver.SetActive(true);
            puntuacioActual.text = puntuacio.ToString();
            if (PlayerPrefs.GetInt("Record") < puntuacio)
            {
                PlayerPrefs.SetInt("Record", puntuacio);
            }
            puntuacioRecord.text = PlayerPrefs.GetInt("Record").ToString();
        }
    }
    public void sumaScoreEnemic1(int punts)
    {
        puntuacio = puntuacio + punts;
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
    public void ReiniciarJoc()
    {
        SceneManager.LoadScene("EraySlasher");
    }

}
