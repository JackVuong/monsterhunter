using UnityEngine;
using System.Collections;

public class ForLoser : MonoBehaviour {
    public GameObject player;
    private Animator anim;
    private float beginScene;
    private GameObject btnReplay;
    private GameObject txt;
    public float time;
    // Use this for initialization
    public void Replay()
    {
        Application.LoadLevel("main");
    }
    void Awake () {
        anim = player.GetComponent<Animator>();
        beginScene = Time.time;
        btnReplay = GameObject.Find("ButtonReplay");
        txt = GameObject.Find("Text");
        btnReplay.SetActive(false);
        txt.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time - beginScene > time)
        {
            anim.SetInteger("PlayerStatus", 2);            
        }
        if(Time.time - beginScene > time+1.5)
        {
            btnReplay.SetActive(true);
            txt.SetActive(true);
        }
	
	}
   
}
