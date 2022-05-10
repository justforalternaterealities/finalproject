using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillGlass : MonoBehaviour
{
    public GameObject water;

    void Start()
    {
        water.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bottle"))
        {
            water.SetActive(true);
        }
    }


    //public void DrinkWater()
    //{
    //    water.SetActive(false);
    //}
}