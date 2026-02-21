// GOOD EXAMPLE - Single Responsibility: Movement Only

using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private float moveSpeed = 5f;
    private Vector3 targetPosition;
    private bool canMove = true;


    public void SetCanMove(bool value)
    {
        canMove = value;
    }

    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }

    private void Update()
    {
        if (!canMove) return;

        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Input.mousePosition;
        }

        transform.position = Vector3.MoveTowards(
            transform.position, targetPosition, moveSpeed * Time.deltaTime);

        Debug.Log($"[Movement] Position: {transform.position}");
    }




}
