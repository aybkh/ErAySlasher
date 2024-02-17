using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baraDeVida : MonoBehaviour
{
    public movimentPlayer player;
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
    public void ConfigurarVidaMaxima(int vides)
    {
        slider.maxValue = vides;
        slider.value = vides;
    }
    // Actualizar la barra de vida del jugador
    public void ActualizarVida(int vida)
    {
        slider.value = vida;
    }

}
