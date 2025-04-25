using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class SceneLoader : MonoBehaviour 
{
    public bool Load(string sceneName)
    {
        // ���������, ��� ����� ����������
        if (SceneUtility.GetBuildIndexByScenePath(sceneName) < 0)
        {
            return false;
        }

        // ��������� �����
        SceneManager.LoadScene(sceneName);
        return true;
    }
}