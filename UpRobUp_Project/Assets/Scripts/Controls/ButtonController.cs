using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonController : MonoBehaviour
{
    PlayerControls playerControls; 
    [SerializeField]
    private SpriteRenderer sR;
    [SerializeField]
    private KeyCode keyToPress;

    [SerializeField]
    private bool CanBePressed;
    void Start()
    {
        playerControls = GetComponent<PlayerControls>();
        sR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(keyToPress) && CanBePressed)
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
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            CanBePressed = false;
        }
    }

}
