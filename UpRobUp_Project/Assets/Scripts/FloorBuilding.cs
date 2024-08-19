using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBuilding : MonoBehaviour
{
    PlayerControls playerControls;
    public GameObject Player;
    public GameObject[] Floors;
    public float position;
    private void Awake()
    {
        playerControls = FindObjectOfType<PlayerControls>();
        playerControls = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerControls>();
    }

    private void Update()
    {
        if (playerControls.GainedPoint)
        {
            Player.transform.position = new Vector2(-2, position + 0.36f);
            Instantiate(Floors[Random.Range(0, Floors.Length)], new Vector2(Player.transform.position.x, Player.transform.position.y), Player.transform.rotation);
            position = position + 2.5f;
            Player.transform.position = new Vector2(-2, position);
            playerControls.GainedPoint = false;
            Player.transform.position = new Vector2(-2, position - 0.36f);
        }    
            
    }

}
