using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AK_ButtonScript : MonoBehaviour
{
    [SerializeField] GameObject destination;
    [SerializeField] GameObject currentCanvas;

    public void PressButton()
    {
        destination.SetActive(true);
        currentCanvas.SetActive(false);    }
}
