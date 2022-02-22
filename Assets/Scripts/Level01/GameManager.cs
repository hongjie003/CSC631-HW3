using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private RectTransform fader;

    private void Start() {
        fader.gameObject.SetActive(true);
        LeanTween.scale (fader, new Vector3(1, 1, 1), 0);
        LeanTween.scale (fader, Vector3.zero, 0.5f).setOnComplete(() => {            
            fader.gameObject.SetActive(false);
        });
    }

    public void SwitchToLightsOn()
    {
        fader.gameObject.SetActive(true);
        LeanTween.scale (fader, Vector3.zero, 0f);
        LeanTween.scale (fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() => {            
            SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex + 1);
        });
    }

    public void SwitchToCubeSurprise()
    {
        fader.gameObject.SetActive(true);
        LeanTween.scale (fader, Vector3.zero, 0f);
        LeanTween.scale (fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() => {            
            SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex + 2);
        });
    }


}
