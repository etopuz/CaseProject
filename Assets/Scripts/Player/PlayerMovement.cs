using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Joystick joystick;

    [Header("Movement Physics")]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    
    public void FixedUpdate()
    {
        Move();
    }
    private void Move(){
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
        direction = direction * speed * Time.fixedDeltaTime;
        
        bool isMoving = direction.magnitude > 0f;

        if(isMoving){
            rb.MovePosition(transform.position + direction);
            rb.MoveRotation(Quaternion.LookRotation(direction));
        }
    }
}
