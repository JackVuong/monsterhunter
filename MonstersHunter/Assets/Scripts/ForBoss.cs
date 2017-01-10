using UnityEngine;
using System.Collections;

public class ForBoss : MonoBehaviour {
    public GameObject bossSkill;
    private Animator anim;
    private int count;
    public float min;
    public float max;
    private float lastime;
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Skill")
        {
            count++;
            if(count == 30)
            {
                Application.LoadLevel("Win1");
            }
            //Debug.Log(count);
        }
    }
            void Start () {
        lastime = Time.time;
        //Combat();
	}
	
	// Update is called once per frame
	void Update () {
        Combat();
        //gameObject.GetComponent<Rigidbody>().AddForce(temp * Time.deltaTime * 100);

    }
    void Combat()
    {
        if(Time.time - lastime >2)
        {
            //Vector3 temp = new Vector3(Random.Range(min, max), 0.5f, 7);
            //gameObject.GetComponent<Rigidbody>().AddForce(temp * Time.deltaTime * 10);
            lastime = Time.time;
            transform.position = new Vector3(Mathf.PingPong(Time.time, 10) - 5, transform.position.y, transform.position.z);
            Instantiate(bossSkill, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+5, gameObject.transform.position.z), gameObject.transform.rotation);
        }      

    }
}
