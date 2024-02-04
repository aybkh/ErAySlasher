using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaraArma : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image Bar;

    public void UpdateHealthBar(movimentPlayer bara)
    {
        Bar.fillAmount = bara.misVides / 100f;
    }
}