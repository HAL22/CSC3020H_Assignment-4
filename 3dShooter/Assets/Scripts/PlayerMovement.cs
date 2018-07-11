using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 10f;

    private Transform player;


    void Start ()
    {

        player = GetComponent<Transform>();


	}

    void rotate()
    {

        


           Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

           float midpoint = (transform.position - Camera.main.transform.position).magnitude*0.5f;

           transform.LookAt(mouseRay.origin + mouseRay.direction * midpoint);


    }

    void movement()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        player.Translate(speed*moveHorizontal*Time.deltaTime,0f,speed*moveVertical*Time.deltaTime);

        rotate();

    }
	
	
	void Update ()
    {

        movement();

       

    }
}
