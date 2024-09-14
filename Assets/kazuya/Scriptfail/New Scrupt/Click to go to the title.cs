using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicktogotothetitle : MonoBehaviour
{

   public void OnTitle()
    {
        SceneManager.LoadScene("MenyScene", LoadSceneMode.Single);
    }
}
