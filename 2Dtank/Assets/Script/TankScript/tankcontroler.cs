using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankcontroler : MonoBehaviour
{
    public Rigidbody2D bullet;
    Rigidbody2D rigid;
    public Transform shoot;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rigid.velocity = direction * 3;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D fire = Instantiate(bullet, shoot.transform.position, shoot.transform.rotation) as Rigidbody2D;
            Vector2 firedirection = transform.TransformDirection(Vector2.up);
            fire.AddForce(firedirection * 1000);
            
        }
        
    }

 
}
