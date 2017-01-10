using UnityEngine;
using System.Collections;

public class MonsterAttack : MonoBehaviour {
    private Rigidbody demon;
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
        demon = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
            return;
        Destroy(other.gameObject);
        anim.SetInteger("MonsterStatus", 1);
        demon.velocity = Vector3.zero;
    }


    // Update is called once per frame
    void Update () {
	
	}
}
