using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
    public List<string> firstDialogue;
    public List<string> secondDialogue;
    public List<string> thirdDialogue;
    public string slogan;
    public string playerTempName;
    public bool hasNickname = true;
    public string nickname;
	// Use this for initialization
	void Start ()
    {
        if(hasNickname == true)
        {
            playerTempName = nickname;
        }
        for (int x = 0; x < firstDialogue.Count; x++)
        {
            firstDialogue[x] = slogan + " " + playerTempName + " " + firstDialogue[x];
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
