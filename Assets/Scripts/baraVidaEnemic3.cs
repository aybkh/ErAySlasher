using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baraVidaEnemic3 : MonoBehaviour
{
    public MovimentsEnemic3 Enemic3;
    [SerializeField]
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ConfigurarVidaMaxima(int videsEnemic3)
    {
        slider.maxValue = videsEnemic3;
        slider.value = videsEnemic3;
    }
    // Actualizar la barra de vida del jugador
    public void ActualizarVida(int vida)
    {
        slider.value = vida;
    }

}