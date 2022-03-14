using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankcontroler : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed;
    Rigidbody2D rigid;
    public Joystick joustic;
    public Transform shoot;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

   direction = new Vector2(joustic.Horizontal, joustic.Vertical);
        


    }
    void FixedUpdate()
    {
        rigid.velocity = direction * speed * Time.fixedDeltaTime;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet = Instantiate(bullet, shoot.transform.position, Quaternion.identity) as Rigidbody2D;

            bullet.AddForce(Vector2.up * 1000);

        }
    }

 
}
