using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
   public void ChangeScene(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }
}
