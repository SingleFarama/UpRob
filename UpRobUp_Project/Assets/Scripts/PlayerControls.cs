using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Controls playerControls;
    private void Awake()
    {
        playerControls = new Controls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Start()
    {
        playerControls.Main.Controls.performed += ctx => Build(ctx.ReadValue<Vector2>());
    }    

    private void Build(Vector2 direction)
    {
        
    }

    private bool CanBuild(Vector2 direction)
    {

    }
}
