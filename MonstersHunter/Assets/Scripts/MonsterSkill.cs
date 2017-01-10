using UnityEngine;
using System.Collections;

public class MonsterSkill : MonoBehaviour {   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel("Lose4");
        }
            
    }
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * 5;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
