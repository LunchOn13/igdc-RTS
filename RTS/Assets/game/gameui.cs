using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class gameui : MonoBehaviour {

	public GameObject buildingtest;
	// Use this for initialization
	void Start () {
		Screen.SetResolution (720, 1280, true);
        Debug.Log("gameuistart");
        Transform ingamebuildarr=GameObject.Find("ingamebuildarray").transform;
        for(int i=0;i<playerinformation.buildinforarray.Count;i++)
        {
            GameObject slot = Instantiate(Resources.Load("ingame/slot", typeof(GameObject)) as GameObject);
            slot.GetComponent<Image>().sprite = playerinformation.buildinforarray[i].getspritebuildmodel();
            slot.GetComponent<Image>().type = Image.Type.Filled;
            slot.name = "" + i;
            slot.transform.parent = ingamebuildarr;
            slot.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
           //     gametmp.GetComponent<unitclass>().icon = Resources.Load<Sprite>("icon/" + unitstatus[i]["icon"]);
           // Resources.Load("misale/" + unitstatus[i]["misaleobject"], typeof(GameObject)) as GameObject;
        }

        ((GameObject)Instantiate(playerinformation.buildinforarray[3].getgameobjectmodel(),
            new Vector3(15,0,34), playerinformation.buildinforarray[3].getgameobjectmodel().transform.rotation)).tag = "ENEMY";
        ((GameObject)Instantiate(playerinformation.buildinforarray[1].getgameobjectmodel(),
           new Vector3(10, 0, 34), playerinformation.buildinforarray[1].getgameobjectmodel().transform.rotation)).tag = "ENEMY";
        ((GameObject)Instantiate(playerinformation.buildinforarray[5].getgameobjectmodel(),
           new Vector3(20, 0, 34), playerinformation.buildinforarray[5].getgameobjectmodel().transform.rotation)).tag = "ENEMY";
    }
	


	// Update is called once per frame
	void Update () {

	}

	public void buildclicktest()
	{
		GetComponent<gamebuild> ().setting (playerinformation.buildinforarray[0].getgameobjectmodel(), new Vector2 (3, 3));
	}

    
}
