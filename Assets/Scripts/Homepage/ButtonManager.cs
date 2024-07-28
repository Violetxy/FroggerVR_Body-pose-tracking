using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject button6;

    public GameObject rule;
    // Start is called before the first frame update
    void Start()
    {
        rule.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitButton()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ClickRuleButton()
    {
        rule.gameObject.SetActive(true);
        button6.gameObject.SetActive(true);
    }

    public void level1load()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(1).name);
    }
    public void CloseButton()
    {
        button6.gameObject.SetActive(false);
        rule.gameObject.SetActive(false);
    }
}
