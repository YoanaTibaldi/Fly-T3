/*using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;    */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            GameObject.Find("Options").GetComponent<Canvas>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Gameplay");
        Debug.Log("tezzzz");
    }

    public void QuitButton() 
    {
        Application.Quit();
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OptionsMenuButton()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void MapMenu()
    {
        SceneManager.LoadScene("Map");
    }

    public void CreditsOnButton()
    {
        Animator anim = GameObject.Find("Ticket").GetComponent<Animator>();

        if (SceneManager.GetActiveScene().name == "OptionsMenu")
        {
            anim.SetBool("CreditsOn", true);
        }
    }
    public void CreditsOffButton()
    {
        Animator anim = GameObject.Find("Ticket").GetComponent<Animator>();

        if (SceneManager.GetActiveScene().name == "OptionsMenu")
        {
            anim.SetBool("CreditsOn", false);
        }
    }

    public void PauseButton()
    {
        if (Time.timeScale == 0)
        {
            GameObject.Find("Options").GetComponent<Canvas>().enabled = false;
            Time.timeScale = 1;
        }
        else
        {
            GameObject.Find("Options").GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
        }
    }
}
