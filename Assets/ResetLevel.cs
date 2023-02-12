using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 137 && transform.position.x < 138 && Input.GetKeyDown(KeyCode.E)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }  
    }
}
