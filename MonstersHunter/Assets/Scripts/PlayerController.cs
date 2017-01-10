using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
    //public Text sc;
    //private static int score = 10;
    public float speed;
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    private Animator anim;
    private float fistTime;
    private float lastTime =0;
   // private bool pressed = false;
    public GameObject skill1;
    public GameObject skill2;
    public GameObject skill3;
    public static int skilID;
    public static int heart;
    public static GameObject h;
    private bool jumping;
    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start () {
        jumping = false;
        skilID = 1;
        heart = 2;
        h = GameObject.Find("Tim");
        //if (PlayerCombat.isLose)
        //{
        //    score--;
        //    sc.text = "Score: " + score;
        //}          
        //else
        //{
        //    sc.text = "Score: " + score;
        //}
    }
    void FixedUpdate()
    {
        //if (Time.time - lastTime > 0.8f)
        //{
        //    anim.SetInteger("PlayerStatus", 0);
        //}
        CheckSpace();
       // CheckJump();
        MovePlayer();       
    }
    // Update is called once per frame
    void Update () {
        Debug.Log(heart);
    }
    void CheckJump()
    {
        if (Input.GetKeyDown("c") &&  jumping == false){
            GetComponent<Rigidbody>().position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.x);
            jumping = true;
            Debug.Log("C");
        }
        if (Input.GetKeyUp("c") && jumping == true)
        {
            jumping = false;
            Debug.Log("Re");
        }

    }
    void MovePlayer()
    {
        var hoz = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");
        if(hoz!= 0)
        {
            anim.SetInteger("PlayerStatus", 3);
        }
        //else
        //{
        //    anim.SetInteger("PlayerStatus", 0);
        //}
        GetComponent<Rigidbody>().velocity = new Vector3(hoz, 0, ver) * speed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), 0, Mathf.Clamp(transform.position.z, zMin, zMax));
        //Vector3 movement = new Vector3(hoz, 0, ver);
        //GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
    void CheckSpace()
    {
        
        if (Input.GetKeyDown("space"))
        {
            //pressed = true;
            anim.SetInteger("PlayerStatus", 1);
            //lastTime = Time.time;
            if(skilID ==1)
            {
                Instantiate(skill1, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z - 6), transform.rotation);
            }
            else if(skilID == 2)
                Instantiate(skill2, new Vector3(transform.position.x, transform.position.y+1, transform.position.z-6), transform.rotation);
            else
                Instantiate(skill3, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z - 6), transform.rotation);

            //yield return new WaitForSeconds(0.5f);
            //anim.SetInteger("PlayerStatus", 0);
        }
        //      

        //else
        //{
        //    anim.SetInteger("PlayerStatus", 0);
        //}
        //if (Input.GetKeyUp("space"))
        //{
        //    anim.SetInteger("PlayerStatus", 0);
        //}
    }
}
