using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavEn : MonoBehaviour
{
    public GameObject En;

    public void OnHover()
    {
        En.SetActive(true);
    }

    public void OnHoverExit()
    {
        En.SetActive(false);
    }
}
