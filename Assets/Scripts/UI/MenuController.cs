using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public CanvasGroup[] contentPanels;
	// Use this for initialization
	void Start () {
        SetActiveContentPanel(contentPanels[0].gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void SetActiveContentPanel(string panelName)
    {
        for (int i = 0; i < contentPanels.Length; i++) {
            if (contentPanels[i].gameObject.name == panelName)
            {
                SetCanvasGroupVisibility(contentPanels[i], true);
                
            }
            else
            {
                SetCanvasGroupVisibility(contentPanels[i], false);
            }
        }
    }
    public void SetCanvasGroupVisibility(CanvasGroup cg, bool isVisible){
        cg.alpha = isVisible ? 1 : 0;
        cg.interactable = isVisible;
        cg.blocksRaycasts = isVisible;
    }
}
