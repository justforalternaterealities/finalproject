using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour
{
    public GameObject mouse;
    public Image lockscreen;
    public Image report;

    void Start()
    {
        lockscreen.gameObject.SetActive(true);
        report.gameObject.SetActive(false);
    }

    public void OnMouseClick()
    {
        lockscreen.gameObject.SetActive(false);
        report.gameObject.SetActive(true);
    }
}