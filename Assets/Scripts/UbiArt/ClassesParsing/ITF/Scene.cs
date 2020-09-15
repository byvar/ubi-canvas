using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Scene {
		protected GameObject gao;
		public GameObject Gao {
			get {
				if (gao == null) {
					InitGameObject();
				}
				return gao;
			}
		}

		protected virtual void InitGameObject() {
			gao = new GameObject("Scene");
			Gao.transform.localPosition = Vec3d.zero;
			Gao.transform.localScale = Vec3d.one;
			Gao.transform.localRotation = Quaternion.identity;
			UnityScene us = Gao.AddComponent<UnityScene>();
			us.scene = this;
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				foreach (Frise f in FRISE) {
					f.SetGameObjectParent(gao);
				}
				foreach (Generic<Actor> a in ACTORS) {
					a.obj.SetGameObjectParent(gao);
				}
			} else {
				foreach (Generic<Pickable> f in FRISE_ORIGINS) {
					f.obj.SetGameObjectParent(gao);
				}
				foreach (Generic<Pickable> a in ACTORS_ORIGINS) {
					a.obj.SetGameObjectParent(gao);
				}
			}
			if (sceneConfigs != null && sceneConfigs.sceneConfigs != null) {
				for (int i = 0; i < sceneConfigs.sceneConfigs.Count; i++) {
					Generic<SceneConfig> sc = sceneConfigs.sceneConfigs[i];
					if (sc.obj != null) sc.obj.InitUnityComponent(this, gao, i);
				}
			}
		}
		public void SetGameObjectParent(GameObject gp, SubSceneActor actor) {
			Gao.transform.SetParent(gp.transform, false);
			Gao.transform.localPosition = Vec3d.zero;
			Gao.transform.localScale = Vec3d.one;
			Gao.transform.localRotation = Quaternion.identity;
			Gao.GetComponent<UnityScene>().subSceneActor = actor;
		}

		public Actor AddActor(Actor a, string name) {
			if (ACTORS != null && a != null && !ACTORS.Any(ac => ac.obj != null && ac.obj == a)) {
				if (a.USERFRIENDLY == null || a.USERFRIENDLY.Length == 0) {
					a.USERFRIENDLY = name;
					int i = 0;
					while(ACTORS.Any(ac => !ac.IsNull && ac.obj.USERFRIENDLY == a.USERFRIENDLY)) {
						a.USERFRIENDLY = name + "@" + i;
						i++;
					}
				}
				a.SetGameObjectParent(gao);
				ACTORS.Add(new Generic<Actor>(a));
			}
			return null;
		}
	}
}
