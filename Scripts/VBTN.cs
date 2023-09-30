using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject l501;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        l501.SetActive(false);
    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        l501.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        l501.SetActive(false);
    }
}
