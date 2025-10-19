using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baraVidaEnemic2 : MonoBehaviour
{
    public MovimentsEnemic2 Enemic2;
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
    public void ConfigurarVidaMaxima(int videsEnemic2)
    {
        slider.maxValue = videsEnemic2;
        slider.value = videsEnemic2;
    }
    // Actualizar la barra de vida del jugador
    public void ActualizarVida(int vida)
    {
        slider.value = vida;
    }

}