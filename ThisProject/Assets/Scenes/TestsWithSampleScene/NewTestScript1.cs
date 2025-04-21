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
        // 1. ���������, ��� ����� ���������� � Build Settings
        int sceneIndex = SceneUtility.GetBuildIndexByScenePath("SampleScene");
        Assert.GreaterOrEqual(sceneIndex, 0, "����� 'SampleScene' �� ��������� � Build Settings!");

        // 2. ��������� �����
        var sceneLoader = new SceneLoader();
        bool isLoaded = sceneLoader.Load("SampleScene");
        Debug.Log(isLoaded);
        // 3. ��������� ���������
        Assert.IsTrue(isLoaded, "����� 'SampleScene' �� �����������!");
    }
}

