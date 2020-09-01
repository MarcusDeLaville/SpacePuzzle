using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OpenPanel(GameObject gameObject)
    {
        gameObject.GetComponent<Animator>().SetBool("isOpen", true);
    }

    public void ClosePanel(GameObject gameObject)
    {
        gameObject.GetComponent<Animator>().SetBool("isOpen", false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
