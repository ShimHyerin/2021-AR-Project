using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dustController : MonoBehaviour
{
    public Button dustBtn;
    public GameObject dust_bad;
    public GameObject dust_good;
    public GameObject dust_soso;
    public Text text_cur_dust;
    void Start()
    {
        text_cur_dust = GameObject.Find("text_cur_dust").GetComponent<Text>();
        dustBtn.onClick.AddListener(ShowDust);
    }
    void ShowDust(){
        Debug.Log("showDust");
        if(text_cur_dust.text == "나쁨"){
            dust_bad.SetActive(true);
        }
        else if(text_cur_dust.text == "좋음"){
            dust_good.SetActive(true);
        }
        else if(text_cur_dust.text == "보통"){
            dust_soso.SetActive(true);
        }
        dustBtn.onClick.AddListener(HideDust);
    }
    void HideDust(){
        Debug.Log("hideDust");
        dust_bad.SetActive(false);
        dust_good.SetActive(false);
        dust_soso.SetActive(false);
        dustBtn.onClick.AddListener(ShowDust);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
