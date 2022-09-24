using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIWork : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {

        Application.Quit();
        Debug.Log("Quit!");

    }

    public void Play()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }






}
