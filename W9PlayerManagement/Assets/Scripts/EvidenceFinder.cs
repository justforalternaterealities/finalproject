using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvidenceFinder : MonoBehaviour
{
    List<string> evidences = new List<string>();
    int layerMask;

    public Text text;

    private void Start()
    {
        layerMask = LayerMask.GetMask("Evidence");
        text = GameObject.FindGameObjectsWithTag("EvidenceText")[0].GetComponent<Text>();

    }

    RaycastHit hit;
    

    private void Update()
    {

        
    }

    public void TakePicture()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000, layerMask))
        {
            hit.collider.gameObject.GetComponentInChildren<Canvas>(true).gameObject.SetActive(true);

        }
        
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    print(hit);
    //}
}
