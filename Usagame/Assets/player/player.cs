using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    Rigidbody2D rigidbody2D;

    public float speed = 3f;
    
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        

            // ���L�[���������獶�����֐i��
            if (Input.GetKey(KeyCode.A)) playerSpeed = -speed;
        // �E�L�[����������E�����֐i��
        else if (Input.GetKey(KeyCode.D)) playerSpeed = speed;
        // ���������Ȃ�������~�܂�
        else playerSpeed = 0;

        rigidbody2D.velocity = new Vector2(playerSpeed, rigidbody2D.velocity.y);
        
       
        
    }
}
