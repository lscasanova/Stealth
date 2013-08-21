using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Version : MonoBehaviour {

	public TextAsset textFile;
	
	private GUIText guiTextInfo;
	
	void Awake()
	{
		guiTextInfo = GetComponent<GUIText>();
		guiTextInfo.text = textFile.ToString();
	}
	
}
