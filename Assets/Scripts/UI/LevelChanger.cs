using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    Animator anim;
    int levelToLoad;

    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        anim.SetTrigger("Fade");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) FadeToLevel(1);
    }

}
