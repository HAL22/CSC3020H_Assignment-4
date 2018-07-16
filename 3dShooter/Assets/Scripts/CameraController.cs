using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    // Public variables
    public GameObject player;
    public float radx=0;
    public float rady=0;
    public float radz=0;
    public bool rot = true;
   

    // Private variables
    private Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        // The initial offset;
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {




        

        // making sure the camera looks at the player object

        transform.LookAt(player.transform);

        if (Input.GetKeyDown(KeyCode.O))
        {

            transform.RotateAround(player.transform.position, Vector3.up, Time.deltaTime * 100);

        }

       // transform.position = player.transform.position + offset;


        





    }
}
