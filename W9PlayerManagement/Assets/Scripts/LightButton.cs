using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightButton : MonoBehaviour
{
    public GameObject light;
    public GameObject phone;

    public float delay = 4;
    public bool lightOn = false;

    void Start()
    {
        light.SetActive(false);
    }

    private void Update()
    {
        phone = GameObject.FindGameObjectWithTag("Phone");
    }

    public void TurnLightOn()
    {
        lightOn = !lightOn;
        light.SetActive(lightOn);
        light.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
        if (phone != null && SceneManager.GetActiveScene().name == "OwnRoom")
        {
            AudioSource audio = phone.GetComponent<AudioSource>();
            audio.PlayDelayed(delay);
        }
    }
}