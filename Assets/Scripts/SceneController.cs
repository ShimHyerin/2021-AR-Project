using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadAR(){
        SceneManager.LoadScene("0602_backup");
    }
    public void LoadFirst(){
        SceneManager.LoadScene("first");
    }
    public void LoadHelp(){
        SceneManager.LoadScene("help");
    }
}
