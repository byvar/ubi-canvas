using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UbiArt.ITF;
using UnityEngine;
using UnityEngine.UI;

public class ZListManager : MonoBehaviour {
	public Dictionary<Renderer, float> zDict = new Dictionary<Renderer, float>();
	//public Dictionary<Renderer 
	//private List<Pickable> zList = new List<Pickable>();

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
	private void LateUpdate() {
		Sort(printMessages: false);
	}
	/*public void Register(Pickable p) {
		zList.Add(p);
	}*/

	/*public void Sort(bool printMessages = true) {
		int zSortValue = 0;
		zList.Sort((p1, p2) => (p2.Gao.transform.position.z.CompareTo(p1.Gao.transform.position.z)));
		for (int i = 0; i < zList.Count; i++) {
			zSortValue = zList[i].UpdateZSortValue(zSortValue);
			if (zSortValue >= 5000) {
				print("Too many renderers for zsort!");
				break;
			}
		}
		if(printMessages) print("ZSort count: " + zList.Count + " - Done zsorting");
	}*/
	public void Sort(bool printMessages = true) {
		/*if (Controller.LoadState == Controller.State.Finished) {
			List<Renderer> zList = FindObjectsOfType<Renderer>().ToList();
			zList.Sort((p1, p2) => (p2.transform.position.z.CompareTo(p1.transform.position.z)));
			for (int i = 0; i < zList.Count; i++) {
				zList[i].sortingOrder = i;
			}
			if (printMessages) print("ZSort count: " + zList.Count + " - Done zsorting");
		}*/
		List<KeyValuePair<Renderer, float>> list = zDict.ToList();
		list.Sort((k1, k2) => k2.Value.CompareTo(k1.Value));
		for (int i = 0; i < list.Count; i++) {
			if (list[i].Key == null || list[i].Key.gameObject == null) {
				zDict.Remove(list[i].Key);
				continue;
			}
			list[i].Key.sortingOrder = i;
		}
		if (printMessages) print("ZSort count: " + list.Count + " - Done zsorting");
	}
}
