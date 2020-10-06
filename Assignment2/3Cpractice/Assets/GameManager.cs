using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("LEVEL WON!");
    }


    public void RloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
