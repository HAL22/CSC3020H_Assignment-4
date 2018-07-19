using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] shape;
    public Material[] material;
    public Vector3 randomPosition;
    public float spawnRate;
    public int startwait = 1;
    public bool stopSpawn;
    private int CurrentShape;
    public int CurrentMaterial;
    private Vector3 CurrentspawnPosition;


	// Use this for initialization
	void Start ()
    {
        stopSpawn = false;

        StartCoroutine(waitSpawner());
        
		
	}
	
	// Update is called once per frame
	void Update ()
    {

		
	}

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startwait); // wait for sstartwait and then executes the code bellow

        while (!stopSpawn)
        {
            CurrentShape = Random.Range(0, shape.Length);

            CurrentspawnPosition = new Vector3(Random.Range(-randomPosition.x,randomPosition.x),1,Random.Range(-randomPosition.z,randomPosition.z));

            CurrentMaterial = Random.Range(0,material.Length);

            GameObject holderShape = shape[CurrentShape];

            target t = holderShape.transform.GetComponent<target>();

            

            if (t != null)
            {
                Debug.Log("Here");
                t.changeMaterial(material[CurrentMaterial]);

                Instantiate(holderShape,CurrentspawnPosition+transform.TransformPoint(0,0,0),gameObject.transform.rotation);
            }

            yield return new WaitForSeconds(spawnRate);



            }


    }
}
