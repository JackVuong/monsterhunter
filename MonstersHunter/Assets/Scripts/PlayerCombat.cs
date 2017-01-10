using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCombat : MonoBehaviour {
    // Use this for initialization
    private Animator anim;
    private float lastTime;
    private float beginSceneTime;
    public GameObject skill;
    private int countSpace = 0;
    private bool finished = false;
    public static bool isLose;
    private int r;
    private GameObject monster;
    private Rigidbody mon_body;
    private Animator mon_anim;
    public Text kq;
    public GameObject btn;
    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start () {
        isLose = false;
        kq.text = "";
        monster = GameObject.Find("Monster");
        mon_body = monster.GetComponent<Rigidbody>();
        mon_anim = monster.GetComponent<Animator>();
        beginSceneTime = Time.time;
        lastTime = beginSceneTime;
        r = Random.Range(0, 100);
        Debug.Log(r);
    }
    void FixedUpdate()
    {
        float forceX = -0.2f;
        mon_body.AddForce(new Vector3(0, 0, forceX));
        if (Time.time - lastTime > 3 && finished == false )
        {
            mon_anim.SetInteger("MonsterStatus", 2);
            finished = true;
            isLose = true;
        }
        if ((Time.time - beginSceneTime) > 10)
        {
            if(r <50 || countSpace < 40)
            {
                mon_anim.SetInteger("MonsterStatus", 2);
                isLose = true;
            }
            finished = true;
        }

        if (Time.time - lastTime > 0.5f && finished == false)
        {
            anim.SetInteger("PlayerStatus", 0);
        }
        if (Time.time - lastTime > 3.7f && isLose)
        {
            finished = true;
            kq.text = "You Lose!";
            anim.SetInteger("PlayerStatus", 2);
            btn.SetActive(true);
        }
        if ((Time.time - beginSceneTime) > 11.5f)
        {
            CheckWinner();
            btn.SetActive(true);
            return;
        }
        
        CheckSpace();

    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
    }
    void CheckSpace()
    {
        if (finished)
            return;
        if (Input.GetKeyDown("space"))
        {
            countSpace++;
            lastTime = Time.time;
            anim.SetInteger("PlayerStatus", 1);
            Instantiate(skill,new Vector3(transform.position.x,transform.position.y+5,transform.position.z-5),transform.rotation);
        }
    }
    void CheckWinner()
    {
        
        if (countSpace < 40 || r< 50) //thua
        {
            kq.text = "You Lose!";
            isLose = true;                     
            anim.SetInteger("PlayerStatus", 2);
        }
        else
        {
            kq.text = "You Win!";
            isLose = false;
            mon_anim.SetInteger("MonsterStatus", 3);
            anim.SetInteger("PlayerStatus", 0);
        }
        Debug.Log(isLose);
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
