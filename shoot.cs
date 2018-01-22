using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject projectileprefab; 

    private List<GameObject> Projectiles = new List<GameObject>();

    private float projectvelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = (GameObject)Instantiate(projectileprefab, transform.position, Quaternion.identity);
            Projectiles.Add(bullet);
        }

	}
}
