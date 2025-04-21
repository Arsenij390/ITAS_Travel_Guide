using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class SceneLoader : MonoBehaviour 
{
    public bool Load(string sceneName)
    {
        // Проверяем, что сцена существует
        if (SceneUtility.GetBuildIndexByScenePath(sceneName) < 0)
        {
            return false;
        }

        // Загружаем сцену
        SceneManager.LoadScene(sceneName);
        return true;
    }
}