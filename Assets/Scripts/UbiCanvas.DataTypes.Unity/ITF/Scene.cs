using Cysharp.Threading.Tasks;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Scene {
		protected GameObject gao;
		public async UniTask<GameObject> GetGameObject() {
			if (gao == null) {
				await InitGameObject();
			}
			return gao;
		}

		protected virtual async UniTask InitGameObject() {
			gao = new GameObject("Scene");
			gao.transform.localPosition = Vector3.zero;
			gao.transform.localScale = Vector3.one;
			gao.transform.localRotation = Quaternion.identity;
			UnityScene us = gao.AddComponent<UnityScene>();
			us.scene = this;
			if (UbiArtContext.Settings.engineVersion > Settings.EngineVersion.RO) {
				if (FRISE != null) {
					foreach (Frise f in FRISE) {
						await f.SetGameObjectParent(gao);
						await f.SetContainingScene(this);
					}
				}
				if (ACTORS != null) {
					foreach (Generic<Actor> a in ACTORS) {
						await a.obj.SetGameObjectParent(gao);
						await a.obj.SetContainingScene(this);
					}
				}
			} else {
				if (FRISE_ORIGINS != null) {
					foreach (Generic<Pickable> f in FRISE_ORIGINS) {
						await f.obj.SetGameObjectParent(gao);
						await f.obj.SetContainingScene(this);
					}
				}
				if (ACTORS_ORIGINS != null) {
					foreach (Generic<Pickable> a in ACTORS_ORIGINS) {
						await a.obj.SetGameObjectParent(gao);
						await a.obj.SetContainingScene(this);
					}
				}
			}
			if (sceneConfigs != null && sceneConfigs.sceneConfigs != null) {
				for (int i = 0; i < sceneConfigs.sceneConfigs.Count; i++) {
					Generic<SceneConfig> sc = sceneConfigs.sceneConfigs[i];
					if (sc.obj != null) sc.obj.InitUnityComponent(this, gao, i);
				}
			}
		}
		public async UniTask SetGameObjectParent(GameObject gp, SubSceneActor actor) {
			if (gao == null) {
				await GetGameObject();
			}
			gao.transform.SetParent(gp.transform, false);
			gao.transform.localPosition = Vector3.zero;
			gao.transform.localScale = Vector3.one;
			gao.transform.localRotation = Quaternion.identity;
			gao.GetComponent<UnityScene>().subSceneActor = actor;
		}
	}
}
