using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    // Este m�todo se llama cuando el bot�n es tocado
    public void LoadScene(string SceneName)
    {
        // Cambiar a la escena especificada por su nombre
        SceneManager.LoadScene(SceneName);
    }
}
