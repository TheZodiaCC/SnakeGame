using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button start_button;
    public Button exit_button;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = start_button.GetComponent<Button>();
        btn.onClick.AddListener(Game);

        Button btn_ex = exit_button.GetComponent<Button>();
        btn_ex.onClick.AddListener(Exit);
    }

    void Game()
    {
        SceneManager.LoadScene("Game");
    }

    void Exit()
    {
        Application.Quit();
    }
}
