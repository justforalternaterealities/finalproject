using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEventCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;

    void Start()
    {
        canvas.worldCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
