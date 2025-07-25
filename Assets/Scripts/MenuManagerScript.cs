using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManagerScript : MonoBehaviour
{
    public GameObject optionPanel;
 


    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void openOptions()
    {
        optionPanel.SetActive(true);
    }

    public void exitGame()
    {
        Debug.Log("Exiting the game");
            Application.Quit();
    }

    public void closeWindow()
    {
        optionPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }

}
