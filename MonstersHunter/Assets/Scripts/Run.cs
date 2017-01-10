using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour {
    private Rigidbody demon;

    // Use this  for initialization
    void Start () {
        demon = GetComponent<Rigidbody>();
        float forceZ = 0f;
        for (int i = 0; i < 10; i++)
        {
            forceZ = -(i);
            demon.AddForce(new Vector3(0, 0, forceZ));
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
