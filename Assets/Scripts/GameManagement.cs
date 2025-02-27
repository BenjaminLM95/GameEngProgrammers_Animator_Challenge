using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneName != SceneManager.GetActiveScene().name)
            sceneName = SceneManager.GetActiveScene().name;


        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(sceneName);

    }
}
