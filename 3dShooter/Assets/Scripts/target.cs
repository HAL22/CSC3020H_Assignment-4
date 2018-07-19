using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

    public float health=50f;
    public Material mat;
    public Renderer rend;

	// Use this for initialization
	void Start ()
    {
       // mat = GetComponent<Material>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = mat;
		
	}

    public void changeMaterial(Material m)
    {
        rend.sharedMaterial = m;
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
