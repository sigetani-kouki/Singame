using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;


    private GameObject bullet;


    public float speed = 3f;
    
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        //bullet = Resources.Load("shot") as GameObject;
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


        // �e�̃C//�V���b�g
       // if (Input.GetMouseButtonDown(0))
        //{
            //�v���n�u����
        //    GameObject bullet = Resources.Load("shot") as GameObject;
        //    bullet.transform.position = this.transform.position;
        //}
        //Instantiate(
          //  bullet, // ��������I�u�W�F�N�g�̃v���n�u
            //this.transform.position, // �����ʒu
            //Quaternion.identity); // ������]���


       
        


        rigidbody2D.velocity = new Vector2(playerSpeed, rigidbody2D.velocity.y);

       
    }
}
