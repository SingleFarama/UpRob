using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public Transform GetDestination()
    {
        return destination;
    }

    [SerializeField] private bool HasButton;
    [SerializeField] private GameObject[] Buttons;
    [SerializeField] private GameObject spawn;
    private void FixedUpdate()
    {
        if (!HasButton)
        {
            Instantiate(Buttons[Random.Range(0, Buttons.Length)], new Vector2(spawn.transform.position.x, spawn.transform.position.y), spawn.transform.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            HasButton = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            HasButton = false;
        }
    }
}
