using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    
    
    public float inc;

    public float minPos;
    public float maxPos;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minPos, maxPos), transform.position.y, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minPos, maxPos), transform.position.y, transform.position.z);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Invoke("Restart", 1f);
            playAudio();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }

    void playAudio()
    {
        GetComponent<AudioSource>().Play();
    }
}

