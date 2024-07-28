using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RemainingLife : MonoBehaviour
{
    public static RemainingLife Instance { get; private set; }
    public static int remainingLives = 5;
    public float reloadDelay = 3;

    public AudioClip sound1;

    L1Manager manager;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife()
    {
        if (remainingLives > 0)
        {
            AudioSource.PlayClipAtPoint(sound1, transform.position);
            remainingLives--;
        }

        if (remainingLives <= 0)
        {
            remainingLives--;
            Debug.Log("No more lives!");
            manager.SetGameOver();
        }
        else
        {
            StartCoroutine(ReloadCurrentSceneWithDelay());
            //ReloadCurrentScene();
        }
    }
    //public void ReloadCurrentScene()
    //{
    //    Scene currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    //    UnityEngine.SceneManagement.SceneManager.LoadScene(currentScene.name);
    //}

    private IEnumerator ReloadCurrentSceneWithDelay()
    {
        yield return new WaitForSeconds(reloadDelay);

        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

}
