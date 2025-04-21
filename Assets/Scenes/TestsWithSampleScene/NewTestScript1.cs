using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void CheckSceneLoading()
    {
        // 1. Проверяем, что сцена существует в Build Settings
        int sceneIndex = SceneUtility.GetBuildIndexByScenePath("SampleScene");
        Assert.GreaterOrEqual(sceneIndex, 0, "Сцена 'SampleScene' не добавлена в Build Settings!");

        // 2. Загружаем сцену
        var sceneLoader = new SceneLoader();
        bool isLoaded = sceneLoader.Load("SampleScene");
        Debug.Log(isLoaded);
        // 3. Проверяем результат
        Assert.IsTrue(isLoaded, "Сцена 'SampleScene' не загрузилась!");
    }
}

