using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBcontroller : MonoBehaviour
{
    public GameObject peaches, peaches_bad;
    VirtualButtonBehaviour vrb;
    void Start()
    {
        peaches.SetActive(false);
        peaches_bad.SetActive(false);
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();

        // for(int i = 0; i < vrb.Length; i++){
        //     vrb[i].RegisterOnButtonPressed(OnButtonPressed);
        //     vrb[i].RegisterOnButtonReleased(OnButtonReleased);
        // }

        vrb.RegisterOnButtonPressed(OnButtonPressed);
        vrb.RegisterOnButtonReleased(OnButtonReleased);
        // Debug.Log(VirtualButtonName);
        

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb){
        peaches.SetActive(true);
        peaches_bad.SetActive(false);
        Debug.Log("Peaches active");

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb){
        peaches.SetActive(false);
        peaches_bad.SetActive(true);
        Debug.Log("Peaches non-active");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
