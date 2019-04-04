using System;
using System.Collections;
using System.Collections.Generic;
using UbiArt.ITF;
using UnityEngine;
using UnityEngine.UI;

public class ZListManager : MonoBehaviour {
	private List<Pickable> zList = new List<Pickable>();

	// Use this for initialization
	void Start() {
	}

    // Update is called once per frame
    void Update() {
		/*Renderer[] zList = FindObjectsOfType<Renderer>();
		if (zList.Length < 5000) {
			for (int i = 0; i < zList.Length; i++) {
				zList[i].transform.position.z
			}
		}*/
		/*Shader.SetGlobalTexture("_LightsFrontLight", frontLight);
		Shader.SetGlobalTexture("_LightsBackLight", backLight);*/
	}

	public void Register(Pickable p) {
		zList.Add(p);
	}

	public void Sort() {
		int zSortValue = 0;
		print("ZSort count: " + zList.Count);
		zList.Sort((p1, p2) => (p2.Gao.transform.position.z.CompareTo(p1.Gao.transform.position.z)));
		print("ZSort count post sort: " + zList.Count);
		for (int i = 0; i < zList.Count; i++) {
			zSortValue = zList[i].UpdateZSortValue(zSortValue);
			if (zSortValue >= 5000) {
				print("Too many renderers for zsort!");
				break;
			}
		}
		print("Done zsorting");
	}


}
