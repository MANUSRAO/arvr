using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelloader : MonoBehaviour
{   
    public GameObject loadingPanel;
    public Slider loadingBar;
    public TextMeshPro progressText;
    public void loadLevel(int sceneIndex){
        StartCoroutine(LoadLevelAsync(sceneIndex));
    }

    IEnumerator LoadLevelAsync(int sceneIndex) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingPanel.SetActive(true);
        while(!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress/0.9f);
            progressText.text = progress * 100f + "%";
            loadingBar.value = progress;
            Debug.Log(progress);
            yield return null;
        }
    }
}
