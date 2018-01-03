using FairyGUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRoot : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
        //设置分辨率
        GRoot.inst.SetContentScaleFactor(600, 480);
        UIPackage.AddPackage("UI/主菜单");
        //创建组件
         GComponent Comp = UIPackage.CreateObject("主菜单", "测试组件").asCom;
        // GRoot.inst.AddChild(Comp);

        Object canvasObjectprefab = Resources.Load("Canvas");
        GameObject canvasObject = (GameObject)Object.Instantiate(canvasObjectprefab);
       

        canvasObject.transform.localPosition = new Vector3(296, -514, 0);
        canvasObject.transform.localScale = new Vector3(1, 1, 1);
        canvasObject.transform.localEulerAngles = new Vector3(0, 0, 0);
        //GGraph holder = view.GetChild("holder").asGraph;
        GGraph holder=Comp.GetChild("n1").asGraph;
        GoWrapper gw = new GoWrapper(canvasObject);

        holder.SetNativeObject(gw);
        GRoot.inst.AddChild(Comp);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
