using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baraVidaEnemic1 : MonoBehaviour
{
    public MovimentsEnemic1 Enemic1;
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
    public void ConfigurarVidaMaxima(int videsEnemic)
    {
        slider.maxValue = videsEnemic;
        slider.value = videsEnemic;
    }
    // Actualizar la barra de vida del jugador
    public void ActualizarVida(int vida)
    {
        slider.value = vida;
    }

}