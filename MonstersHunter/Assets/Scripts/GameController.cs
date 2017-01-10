using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public float xMinMAx;
    public float zMin;
    public GameObject monster1;
    public GameObject monster2;
    public GameObject monster3;
    public GameObject boss;
    private bool boosIsCalled;
    public int count;
    public float StartWait;
    public float cloneWait;
    public float beginSceneTime;
    // Use this for initialization
    void Start () {
        beginSceneTime = Time.time;
        if(tag == "Level1")
        {
            StartCoroutine(Level1());
        }
        if (tag == "Level2")
        {
            StartCoroutine(Level2());
        }

        boosIsCalled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time - beginSceneTime > 43 && boosIsCalled == false)
        {
            Quaternion q = transform.rotation;
            q.y = 180;
            Instantiate(boss, new Vector3(0, -0.8f, 7), q);
            boosIsCalled = true;
        }
	}
    IEnumerator Level1()
    {
        while (Time.time- beginSceneTime < 30)
        {
            yield return new WaitForSeconds(StartWait);
            for (int i = 0; i < count; i++)
            {
                int r = Random.Range(1, 3);
                //Debug.Log(r);
                if(r == 1)
                {
                    Quaternion q = transform.rotation;
                    q.y = -180;
                    Instantiate(monster1, new Vector3(Random.Range(-xMinMAx, xMinMAx), 0, zMin), q);
                }
                if (r == 2)
                {
                    Quaternion q = transform.rotation;
                    q.y = -180;
                    Instantiate(monster2, new Vector3(Random.Range(-xMinMAx, xMinMAx), 0, zMin), q);
                }

                yield return new WaitForSeconds(cloneWait);
            }

        }
    }
    IEnumerator Level2()
    {
        while (Time.time - beginSceneTime < 40)
        {
            yield return new WaitForSeconds(StartWait);
            for (int i = 0; i < count + 5; i++)
            {
                int r = Random.Range(1, 4);
                //Debug.Log(r);
                if (r == 1)
                {
                    Quaternion q = transform.rotation;
                    q.y = -180;
                    Instantiate(monster1, new Vector3(Random.Range(-xMinMAx, xMinMAx), 0, zMin), q);
                }
                if (r == 2)
                {
                    Quaternion q = transform.rotation;
                    q.y = -180;
                    Instantiate(monster2, new Vector3(Random.Range(-xMinMAx, xMinMAx), 0, zMin), q);
                }
                if (r == 3)
                {
                    Quaternion q = transform.rotation;
                    q.y = 360;
                    Instantiate(monster3, new Vector3(Random.Range(-xMinMAx, xMinMAx), 0, zMin), q);
                }

                yield return new WaitForSeconds(cloneWait);
            }

        }
    }
}
