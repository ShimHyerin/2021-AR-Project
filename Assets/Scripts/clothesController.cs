using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clothesController : MonoBehaviour
{
    public Button clothesBtn;
    public Button clothes_close;
    public GameObject page_clothes;
    public Text text_cur_temp;
    public Text weather;
    public Text top1;
    public Text top2;
    public Text bottom1;
    public Text bottom2;
    public Text etc1;
    public Text etc2;

    private int temp;


    // Start is called before the first frame update
    void Start()
    {
        text_cur_temp = GameObject.Find("text_cur_temp").GetComponent<Text>();
        clothesBtn.onClick.AddListener(ShowClothes);
        temp = int.Parse(text_cur_temp.text);
    }
    void ShowClothes(){
        text_cur_temp = GameObject.Find("text_cur_temp").GetComponent<Text>();
        temp = int.Parse(text_cur_temp.text);
        if(temp >= 28){
            Debug.Log("hi");
            weather.GetComponent<Text>().text = "아이고 덥다..";
            top1.GetComponent<Text>().text = "민소매";
            top2.GetComponent<Text>().text = "반팔";
            bottom1.GetComponent<Text>().text = "반바지";
            bottom2.GetComponent<Text>().text = "";
            etc1.GetComponent<Text>().text = "선풍기";
            etc2.GetComponent<Text>().text = "선크림";
        }
        else if(temp >= 23){
            weather.GetComponent<Text>().text = "더워요~";
            top1.GetComponent<Text>().text = "얇은\n셔츠";
            top2.GetComponent<Text>().text = "반팔";
            bottom1.GetComponent<Text>().text = "반바지";
            bottom2.GetComponent<Text>().text = "면바지";
            etc1.GetComponent<Text>().text = "선풍기";
            etc2.GetComponent<Text>().text = "선크림";
        }
        else if(temp >= 20){
            weather.GetComponent<Text>().text = "선선해요";
            top1.GetComponent<Text>().text = "반팔";
            top2.GetComponent<Text>().text = "긴팔";
            bottom1.GetComponent<Text>().text = "청바지";
            bottom2.GetComponent<Text>().text = "면바지";
            etc1.GetComponent<Text>().text = "가디건";
            etc2.GetComponent<Text>().text = "";
        }
        else if(temp >= 17){
            weather.GetComponent<Text>().text = "제법쌀쌀함!";
            top1.GetComponent<Text>().text = "얇은\n니트";
            top2.GetComponent<Text>().text = "긴팔";
            bottom1.GetComponent<Text>().text = "청바지";
            bottom2.GetComponent<Text>().text = "슬랙스";
            etc1.GetComponent<Text>().text = "바람\n막이";
            etc2.GetComponent<Text>().text = "후드\n집업";
        }
        else if(temp >= 12){
            weather.GetComponent<Text>().text = "밤에추워짐";
            top1.GetComponent<Text>().text = "기모\n후드";
            top2.GetComponent<Text>().text = "니트";
            bottom1.GetComponent<Text>().text = "청바지";
            bottom2.GetComponent<Text>().text = "슬랙스";
            etc1.GetComponent<Text>().text = "가디건";
            etc2.GetComponent<Text>().text = "자켓";
        }
        else if(temp >= 9){
            weather.GetComponent<Text>().text = "살짝추워요";
            top1.GetComponent<Text>().text = "니트";
            top2.GetComponent<Text>().text = "후드";
            bottom1.GetComponent<Text>().text = "청바지";
            bottom2.GetComponent<Text>().text = "슬랙스";
            etc1.GetComponent<Text>().text = "코트";
            etc2.GetComponent<Text>().text = "스타킹";
        }
        else if(temp >= 5){
            weather.GetComponent<Text>().text = "추워요~";
            top1.GetComponent<Text>().text = "니트";
            top2.GetComponent<Text>().text = "히트텍";
            bottom1.GetComponent<Text>().text = "청바지";
            bottom2.GetComponent<Text>().text = "레깅스";
            etc1.GetComponent<Text>().text = "코트";
            etc2.GetComponent<Text>().text = "숏패딩";
        }
        else{
            weather.GetComponent<Text>().text = "아이고춥다..";
            top1.GetComponent<Text>().text = "롱패딩";
            top2.GetComponent<Text>().text = "기모\n상의";
            bottom1.GetComponent<Text>().text = "기모\n바지";
            bottom2.GetComponent<Text>().text = "";
            etc1.GetComponent<Text>().text = "핫팩";
            etc2.GetComponent<Text>().text = "목도리";
        }
        page_clothes.SetActive(true);
        clothes_close.onClick.AddListener(HideClothes);
    }
    void HideClothes(){
        page_clothes.SetActive(false);
        clothesBtn.onClick.AddListener(ShowClothes);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
