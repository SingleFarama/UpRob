using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Secure : MonoBehaviour
{
    public bool IsOnsecurer;
    Collider2D other;

    void Start () 
    {
        other = GetComponent<Collider2D>();
    }
    void Update()
    {
        if (other.tag != "Secure")
        {
            IsOnsecurer = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Secure")
        {
            IsOnsecurer = true;
        }
    }
    }
