using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHoldController : MonoBehaviour
{
    public GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        turnOffCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnOnCamera()
    {
        screen.SetActive(true);
    }

    public void turnOffCamera()
    {
        screen.SetActive(false);
    }
}
