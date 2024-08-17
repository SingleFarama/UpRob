using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool HasButtonInteractable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            HasButtonInteractable = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            HasButtonInteractable = false;
        }
    }
}
