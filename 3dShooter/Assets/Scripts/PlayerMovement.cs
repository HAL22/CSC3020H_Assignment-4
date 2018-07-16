using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 10f;
    private Transform player;
    Vector2 mouseLook;
    Vector2 smooth;
    public float sen = 4.4f;
    public float sm = 3.2f;


    void Start ()
    {
        player = GetComponent<Transform>();

	}

    void rotate()
    {

        Vector2 mouseVec = new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y"));

        mouseVec = Vector2.Scale(mouseVec, new Vector2(sen * sm, sen * sm));

        smooth.x = Mathf.Lerp(smooth.x, mouseVec.x, 1F / sm);
        smooth.y = Mathf.Lerp(smooth.y, mouseVec.y, 1F / sm);

        mouseLook += smooth;

        transform.localRotation = Quaternion.AngleAxis(mouseLook.x, transform.up);

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
