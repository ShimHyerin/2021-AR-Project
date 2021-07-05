using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject info;
    public Button infoBtn;

    
    void Start()
    {
        info.SetActive(false);
        infoBtn.onClick.AddListener(ShowInfo);
    }

    void ShowInfo(){
        info.SetActive(true);
        infoBtn.onClick.AddListener(HideInfo);
    }

    void HideInfo(){
        info.SetActive(false);
        infoBtn.onClick.AddListener(ShowInfo);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
