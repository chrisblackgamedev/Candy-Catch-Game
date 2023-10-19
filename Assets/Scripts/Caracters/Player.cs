using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private LayerMask groundLayers;
    
    private bool isGrounded;
    private Vector3 _moveDir;
    
    private float depth;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(myPlayer:this);
        InputManager.GameMode();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDir;
    }
    
    public void SetMovementDirection(Vector3 newDirection)
    {
        _moveDir = newDirection;
        //Debug.Log("Shoot");
    }

  
    private void CheckGround()
   {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, depth, groundLayers);
        Debug.DrawRay(transform.position, Vector3.down * depth,
            Color.green, 0, false);
    }

    
}