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

    public TextMeshProUGUI marcadorScore;
    public TextMeshProUGUI marcadorScore2;
    public TextMeshProUGUI marcadorScore3;



    public TextMeshProUGUI puntuacioActual;
    public TextMeshProUGUI puntuacioRecord;
    public TextMeshProUGUI puntuacioActual2;
    public TextMeshProUGUI puntuacioRecord2;
    public TextMeshProUGUI puntuacioActual3;
    public TextMeshProUGUI puntuacioRecord3;
    public GameObject gameOver;



    private int puntuacio;
    private int puntuacioE2;
    private int puntuacioE3;

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
        marcadorScore3.text = " " + ScoreEnemic3();

        if ((Player.Vides() <= 0) && (gameOver.activeSelf == false))
        {
            gameOver.SetActive(true);
            puntuacioActual.text = puntuacio.ToString();
            if (PlayerPrefs.GetInt("Record") < puntuacio)
            {
                PlayerPrefs.SetInt("Record", puntuacio);
            }
            puntuacioRecord.text = PlayerPrefs.GetInt("Record").ToString();

            puntuacioActual2.text = puntuacioE2.ToString();
            if (PlayerPrefs.GetInt("Record2") < puntuacioE2)
            {
                PlayerPrefs.SetInt("Record2", puntuacioE2);
            }
            puntuacioRecord2.text = PlayerPrefs.GetInt("Record2").ToString();

            puntuacioActual3.text = puntuacioE3.ToString();
            if (PlayerPrefs.GetInt("Record3") < puntuacioE3)
            {
                PlayerPrefs.SetInt("Record3", puntuacioE3);
            }
            puntuacioRecord3.text = PlayerPrefs.GetInt("Record3").ToString();
        }
    }
    public void sumaScoreEnemic1(int punts)
    {
        puntuacio  += punts;
    }
    public int DonarPunts()
    {
        return puntuacio;
    }
    public void sumaScoreEnemic2(int puntsEnemic2)
    {
        puntuacioE2 += puntsEnemic2;

    }
    public int ScoreEnemic2()
    {
        return puntuacioE2;
    }
    public void sumaScoreEnemic3(int puntsEnemic3)
    {
        puntuacioE3 += puntsEnemic3;

    }
    public int ScoreEnemic3()
    {
        return puntuacioE3;
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
