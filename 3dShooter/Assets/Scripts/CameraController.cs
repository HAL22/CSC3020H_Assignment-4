using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    // Public variables
    public GameObject player;
    public  bool rot = true;
    public float height=1;
    public float length=1;
   

    // Private variables
    private Vector3 offset;

    private Vector3 edit;

    // Use this for initialization
    void Start ()
    {
        edit.x = length;
        edit.y = height;
        edit.z = length;
        // The initial offset;
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {

        edit.x = length;
        edit.y = height;
        edit.z = length;


        if (Input.GetKey(KeyCode.N))
        {
            rot = true;

        }

        if (Input.GetKey(KeyCode.M))
        {
            rot = false;
        }

        // making sure the camera looks at the player object

        transform.LookAt(player.transform);


        if (!rot)
        {

            transform.position = player.transform.position + offset+edit;

        }

       

        if (rot)
        {

            transform.RotateAround(player.transform.position, Vector3.up, Time.deltaTime * 100);

        }

      


        





    }
}
