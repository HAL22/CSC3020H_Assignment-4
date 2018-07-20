using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

    public float health=50f;
  
  

	// Use this for initialization
	void Start ()
    {
       //s mat = GetComponent<Material>();

       

		
	}

    public void changeMaterial(Material m)
    {
        GetComponent<Renderer>().material  = m;
    }



    public void damage(float amount)
    {
        health = health - amount;

        if (health <= 0)
        {
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
