using UnityEngine;
using System.Collections;

public class CombatController : MonoBehaviour {

    public void Replay()
    {
        Application.LoadLevel("main");
    }
    // Use this for initialization
    void Start () {
        GameObject btn = GameObject.Find("Button");
        btn.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
