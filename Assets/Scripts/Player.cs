using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameInput gameInput;
    [SerializeField] private float _speed = 7f;
    
    private void Update() {
        HandleMovement();
    }

    private void HandleMovement() {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        moveDistance = _speed * Time.deltaTime;
        tranform.position += moveDir * moveDistance;
    }
}