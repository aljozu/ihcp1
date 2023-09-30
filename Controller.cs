using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
   public void MoveToScene(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }
}
