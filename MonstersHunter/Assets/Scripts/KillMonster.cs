using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillMonster : MonoBehaviour {
    private int count;
    public GameObject item1;
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (tag == "Skeleton")
            {
                PlayerController.heart--;
                Debug.Log("a");
                if (PlayerController.heart < 0)
                    Application.LoadLevel("Lose1");
                //Destroy(other.gameObject);
                PlayerController.h.SetActive(false);

            }
            if (tag == "Dungeon")
            {
                PlayerController.heart--;
                if (PlayerController.heart < 0)
                    Application.LoadLevel("Lose2");
                //Destroy(other.gameObject);
                PlayerController.h.SetActive(false);

            }
            if (tag == "Zombie")
            {
                PlayerController.heart--;
                if (PlayerController.heart < 0)
                    Application.LoadLevel("Lose3");
                //Destroy(other.gameObject);
                PlayerController.h.SetActive(false);

            }
        }
        if (other.tag == "Skill")
        {
            if (tag == "Skeleton")
            {
                Destroy(other.gameObject);
                count++;
                if (count == 1)
                {
                    Destroy(gameObject);
                    int ran = Random.Range(0, 100);
                    if(ran>90)
                    {
                        Instantiate(item1, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
                    }                   
                }

                return;
            }
            if (tag == "Dungeon")
            {
                count++;
                Destroy(other.gameObject);
                if (count == 2)
                {
                    Destroy(gameObject);
                    int ran = Random.Range(0, 100);
                    if (ran > 95)
                    {
                        Instantiate(item1, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
                    }
                }
                return;
            }
            if (tag == "Zombie")
            {
                count++;
                Destroy(other.gameObject);
                if (count == 3)
                {
                    int ran = Random.Range(0, 100);
                    if (ran > 95)
                    {
                        Instantiate(item1, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
                    }
                    Destroy(gameObject);
                }
                    
                return;
            }
        }  
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
