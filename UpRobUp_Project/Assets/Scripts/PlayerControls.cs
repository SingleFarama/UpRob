using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public int Points = 0;

    public float Timer = 5f;

    private void Update()
    {
        Debug.Log(Points);
    }

    private void Build()
    {
        if (Input.anyKey || gameObject.IsDestroyed())
        {
            Points++;
        }
        //Se ele apertar tecla correta
        //- Contagem aumenta em 1
        //- Construção aumenta em 1 andar

        //Se apertar tecla incorreta
        //- Contagem diminui em 1
        //- Construção diminui me 1 andar
    }

}
