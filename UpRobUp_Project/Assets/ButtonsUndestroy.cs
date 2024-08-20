using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsUndestroy : MonoBehaviour
{
    FloorBuilding floorBuilding;
    Secure secure;

    void Start()
    {
        floorBuilding = GetComponent<FloorBuilding>();
        floorBuilding = FindObjectOfType<FloorBuilding>();
        secure = FindObjectOfType<Secure>();
        secure = GetComponent<Secure>();
    }
    void Update()
    {
        if (floorBuilding.StartedBuilding && secure.IsOnsecurer == false)
        {
            Destroy(gameObject);
        }
    }
}
