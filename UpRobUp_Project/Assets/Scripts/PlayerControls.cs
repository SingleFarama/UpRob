using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public int CurrentPoints;
    public int PointsPerButton = 1;
    public int HighScore;
    public int FailedButtons;
    public bool GainedPoint;
    public TextMeshProUGUI PointsText;
    public TextMeshProUGUI HighPointsText;
    FloorBuilding floorBuilding;

    public float Timer = 5f;
    public float CurrentTimer;
    public TextMeshProUGUI TimerText;
    public AudioSource Music;

    void Start()
    {
        Music.Play();
        floorBuilding = GetComponent<FloorBuilding>();
        floorBuilding = FindObjectOfType<FloorBuilding>();
        PointsText.text = "Current Floor: 0";
    } 

    void Update()
    {
        if (CurrentPoints > HighScore)
        {
            HighScore = CurrentPoints;
        }
        HighPointsText.text = "Highest Floor: " + HighScore;

        if (floorBuilding.StartedBuilding == true)
        {
            Timer = Timer - Time.deltaTime;
            CurrentTimer = Timer;
        }

        if (CurrentTimer < 0f)
        {
            floorBuilding.StartedBuilding = false;
        }
        if (floorBuilding.StartedBuilding == false)
        {
            CurrentTimer = 5f;
            PointsText.text = "Current Floor: 0";
            CurrentPoints = 0;
        }
        TimerText.text = "Timer: " + CurrentTimer;

    }

    public void ButtonHit()
    {
        GainedPoint = true;
        Timer = CurrentTimer + 1f;
        CurrentPoints += PointsPerButton;
        PointsText.text = "Current Floor: " + CurrentPoints;
    }

    public void ButtonFailed()
    {
        if (floorBuilding.StartedBuilding == true)
        {
            Timer = Timer - 1f;
        }
    }

}
