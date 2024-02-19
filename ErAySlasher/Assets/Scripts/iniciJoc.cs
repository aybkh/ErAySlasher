using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class iniciJoc : MonoBehaviour
{
    public GameObject Opcions;
    public GameObject Panel;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AJugar()
    {
        SceneManager.LoadScene("EraySlasher");
    }
    public void Exit()
    {
        UnityEngine.Application.Quit();
    }
    public void opcions()
    {
        if (Opcions.activeSelf == false)
        {
            Opcions.SetActive(true);
            Panel.SetActive(false);
        }

    }
    public void menu()
    {
        SceneManager.LoadScene("UI-Inici");
    }
}