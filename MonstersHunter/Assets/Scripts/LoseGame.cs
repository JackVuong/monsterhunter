using UnityEngine;
using System.Collections;

public class LoseGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Skeleton")
        {
            PlayerController.heart--;
            if (PlayerController.heart < 0)
                Application.LoadLevel("Lose1");
            Destroy(other.gameObject);
            PlayerController.h.SetActive(false);
            
        }
        if (other.tag == "Dungeon")
        {
            PlayerController.heart--;
            if (PlayerController.heart < 0)
                Application.LoadLevel("Lose2");
            Destroy(other.gameObject);
            PlayerController.h.SetActive(false);

        }
        if (other.tag == "Zombie")
        {
            PlayerController.heart--;
            if (PlayerController.heart < 0)
                Application.LoadLevel("Lose3");
            Destroy(other.gameObject);
            PlayerController.h.SetActive(false);

        }
        if(other.tag == "BossSKill")
        {
            Destroy(other.gameObject);
        }
        

    }

        // Update is called once per frame
        void Update () {
	
	}
}
