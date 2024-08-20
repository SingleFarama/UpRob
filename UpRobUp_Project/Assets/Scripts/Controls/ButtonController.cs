using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    PlayerControls playerControls;
    Spawner spawner;
    Transform InstanceInteractable;
    Secure secure;
    FloorBuilding floorBuilding;

    void Start()
    {
        interactable = FindObjectOfType<Interactable>();
        playerControls = FindObjectOfType<PlayerControls>();
        secure = FindObjectOfType<Secure>();
        secure = GetComponent<Secure>();
        spawner = FindObjectOfType<Spawner>();
        floorBuilding = GetComponent<FloorBuilding>();
        floorBuilding = FindObjectOfType<FloorBuilding>();
        playerControls = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerControls>();
        InstanceInteractable = Interactable.InstanceInteractable.transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && CanBePressed)
        {
            playerControls.ButtonHit();
            floorBuilding.StartedBuilding = true;
            Destroy(gameObject);
        }
        else if (Input.GetKeyDown(keyToPress) && !CanBePressed)
        {
            playerControls.ButtonFailed();
        }
        if (IsOnSpawner && !CanBePressed && interactable.HasButtonInteractable == false)
        {
            transform.position = InstanceInteractable.position;
        }
        if (playerControls.CurrentTimer < 0 && secure.IsOnsecurer == false)
        {
            Destroy(gameObject);
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
