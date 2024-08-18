using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonController : MonoBehaviour
{
    [SerializeField] 
    private KeyCode keyToPress;
    [SerializeField] 
    private bool CanBePressed;
    [SerializeField] 
    private bool IsOnSpawner;
    [SerializeField]
    private GameObject currentTeleporter;
    Interactable interactable;

    Transform InstanceInteractable;

    void Start()
    {
        interactable = FindObjectOfType<Interactable>();
        InstanceInteractable = Interactable.InstanceInteractable.transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && CanBePressed)
        {
            Destroy(gameObject);
        }
        if (IsOnSpawner && !CanBePressed && interactable.HasButtonInteractable == false)
        {
            transform.position = InstanceInteractable.position;
            print("Teleporte");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            CanBePressed = true;
        }
        if (other.tag == "Spawner")
        {
            currentTeleporter = other.gameObject;
            IsOnSpawner = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            CanBePressed = false;
        }
        if (other.tag == "Spawner")
        {
            if (other.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
                IsOnSpawner = false;
            }
        }
    }

    private void OnDestroy()
    {
        interactable.HasButtonInteractable = false;
    }
}
