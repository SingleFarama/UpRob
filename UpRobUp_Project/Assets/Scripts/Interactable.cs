using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{ 
    public bool HasButtonInteractable;
    private static Interactable InteractableInstance;
    public static Interactable InstanceInteractable 
    { 
        get 
        { 
            return Interactable.InteractableInstance; 
        } 
    } 

    private void Awake()
    {
        if (Interactable.InteractableInstance == null)
        {
            InteractableInstance = this;
        }
        else
        {
            Destroy(Interactable.InteractableInstance);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            HasButtonInteractable = true;
        }
    }
    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.tag == "Button")
    //    {
    //        HasButtonInteractable = false;
    //    }
    //}
}
