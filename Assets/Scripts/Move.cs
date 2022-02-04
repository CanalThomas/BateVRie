using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{

    [SerializeField] private InputActionReference _actionReference = null;
    private float Distance= 3.0f;

    protected void OnActionStarted(InputAction.CallbackContext ctx)
    {
        Debug.Log(_actionReference.name + "/" + ctx.action.name + " pressed");
        gameObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * Distance;
    }
   
}
