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
			gao.transform.localPosition = Vec3d.Zero;
			gao.transform.localScale = Vec3d.One;
			gao.transform.localRotation = Quaternion.identity;
			UnityScene us = gao.AddComponent<UnityScene>();
			us.scene = this;
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				foreach (Frise f in FRISE) {
					await f.SetGameObjectParent(gao);
				}
				foreach (Generic<Actor> a in ACTORS) {
					await a.obj.SetGameObjectParent(gao);
				}
			} else {
				foreach (Generic<Pickable> f in FRISE_ORIGINS) {
					await f.obj.SetGameObjectParent(gao);
				}
				foreach (Generic<Pickable> a in ACTORS_ORIGINS) {
					await a.obj.SetGameObjectParent(gao);
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
			gao.transform.localPosition = Vec3d.Zero;
			gao.transform.localScale = Vec3d.One;
			gao.transform.localRotation = Quaternion.identity;
			gao.GetComponent<UnityScene>().subSceneActor = actor;
		}

		public async UniTask<Actor> AddActor(Actor a, string name) {
			if (ACTORS != null && a != null && !ACTORS.Any(ac => ac.obj != null && ac.obj == a)) {
				if (a.USERFRIENDLY == null || a.USERFRIENDLY.Length == 0) {
					a.USERFRIENDLY = name;
					int i = 0;
					while(ACTORS.Any(ac => !ac.IsNull && ac.obj.USERFRIENDLY == a.USERFRIENDLY)) {
						a.USERFRIENDLY = $"{name}@{i}";
						i++;
					}
				}
				await a.SetGameObjectParent(gao);
				ACTORS.Add(new Generic<Actor>(a));
			}
			return null;
		}
	}
}
