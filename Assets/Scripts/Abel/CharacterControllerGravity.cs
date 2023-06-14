using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControllerGravity : MonoBehaviour
{
    private CharacterController _characterController;
    private bool _climbing;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        ClimbProvider.ClimbActive += ClimbActive;
        ClimbProvider.ClimbInActive += ClimbInactive;
    }
    private void OnDestroy()
    {
        ClimbProvider.ClimbActive -= ClimbActive;
        ClimbProvider.ClimbInActive -= ClimbInactive;
    }

    private void Update()
    {
        if (!_characterController.isGrounded && !_climbing)
        {
            _characterController.SimpleMove(new Vector3());
        }
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(0, 10f, 0);
        }
    }

    private void ClimbActive()
    {
        _climbing = true;
        _characterController.center = new Vector3(0, 1f, 0);
    }
    private void ClimbInactive()
    {
        _climbing = false;
        _characterController.center = new Vector3(0, 0, 0);
    }
}
