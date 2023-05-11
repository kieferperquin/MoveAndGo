using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerGravity : MonoBehaviour
{
    private CharacterController _characterController;
    private bool _climbing;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        ClimbProvider.ClimbActive += ClimbActive;
        ClimbProvider.ClimbActive += ClimbInactive;
    }
    private void OnDestroy()
    {
        ClimbProvider.ClimbActive -= ClimbActive;
        ClimbProvider.ClimbActive -= ClimbInactive;
    }

    private void Update()
    {
        if (!_characterController.isGrounded && _climbing)
        {
            _characterController.SimpleMove(new Vector3());
            Debug.Log("Gravity Applied");
        }
        if (_characterController.isGrounded)
        {
            // Debug.Log("grounded!");
        }
    }

    private void ClimbActive()
    {
        _climbing = true;
        Debug.Log("climb activated!");
    }
    private void ClimbInactive()
    {
        _climbing = false;
        Debug.Log("climb deactivated!");
    }
}
