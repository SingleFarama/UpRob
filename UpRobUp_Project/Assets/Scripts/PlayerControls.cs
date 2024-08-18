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
    public TextMeshProUGUI PointsText;

    public float Timer = 5f;

    void Start()
    {
        PointsText.text = "0";
    } 

    public void ButtonHit()
    {
        print("Button Hit");
        CurrentPoints += PointsPerButton;
        PointsText.text = "" + CurrentPoints;
    }

    public void ButtonFailed()
    {
        print("Button Failed");
    }

    //private void Update()
    //{
    //    Debug.Log(Points);
    //}

    //private void Build()
    //{
       // if (Input.anyKey || gameObject.IsDestroyed())
        //{
        //    Points++;
        //}
        //Se ele apertar tecla correta
        //- Contagem aumenta em 1
        //- Construção aumenta em 1 andar

        //Se apertar tecla incorreta
        //- Contagem diminui em 1
        //- Construção diminui me 1 andar
    //}

}
