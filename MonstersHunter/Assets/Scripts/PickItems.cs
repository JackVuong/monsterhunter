using UnityEngine;
using System.Collections;

public class PickItems : MonoBehaviour {
    // Use this for initialization
    public int ID;
	void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (tag == "Heart")
            {
                Destroy(gameObject);
                PlayerController.heart = 2;
                PlayerController.h.SetActive(true);
                return;
            }
                
            Destroy(gameObject);
            PlayerController.skilID = ID;
            //Debug.Log("picked");
            //PlayerController.skill = newSkill;
        }
    }
    // Update is called once per frame
    void Update () {
        transform.Rotate(0, 200 * Time.deltaTime, 0);
    }
}
