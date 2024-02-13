using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaraVida : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image Bara;

    public void UpdateHealthBar(movimentPlayer bara)
    {
        Bara.fillAmount = bara.misVides / 10f;
    }
}