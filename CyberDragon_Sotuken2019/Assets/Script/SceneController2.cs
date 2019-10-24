using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0f, 0f);
        }

        Vector3 pos = transform.position;
        if((pos.z > 53) || (pos.z < -53))
        {
            SceneManager.LoadScene("battle");
        }

        transform.position = pos;
    }

}
