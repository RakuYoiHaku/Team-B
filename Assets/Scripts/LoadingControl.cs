using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingControl : MonoBehaviour
{
    // �� ��ȯ �Լ�
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
