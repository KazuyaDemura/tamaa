using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class displayChange : MonoBehaviour
{

    void Start()
    {

    }

    //オブジェクトが衝突したとき
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "DMURA")
        {
            SceneManager.LoadScene("GAMEOVER");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DMURA")
        {
            SceneManager.LoadScene("GAMEOVER");
        }
    }   
}