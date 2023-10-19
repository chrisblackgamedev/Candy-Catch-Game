using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager 
{
    private static Controls _controls;

    public static void Init(Player myPlayer)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += hi =>
        {
            myPlayer.SetMovementDirection(hi.ReadValue<Vector3>());
        };

        _controls.Game.Jump.started += hi => 
        {
            //Debug.Log("Is this working?");
        };

        _controls.Permanent.Enable();
    
    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UIMode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();
    }

}