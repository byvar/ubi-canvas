using ITF.ActorComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SubSceneActor : Actor {
		[Serialize(0, "RELATIVEPATH")] public Path relativePath;
		[Serialize(1, "EMBED_SCENE")] public bool embedScene;
		[Serialize(2, "IS_SINGLE_PIECE")] public bool isSinglePiece;
		[Serialize(3, "ZFORCED")] public bool zForced;
		[Serialize(4, "DIRECT_PICKING")] public bool directPicking;
		[Serialize(5, "viewType")] public ViewType viewType;
		[Serialize(6, "SCENE")] public Nullable<Scene> scene;

		protected override void InitGameObject() {
			base.InitGameObject();
			if (scene.read) {
				foreach (Frise f in scene.obj.frise) {
					f.Gao.transform.SetParent(gao.transform);
				}
				foreach (Generic<Actor> a in scene.obj.actors) {
					a.obj.Gao.transform.SetParent(gao.transform);
				}
			}
		}

		public SubSceneActor(Reader reader) : base(reader) {
		}

		public enum ViewType {
			Main,
			Remote,
			All,
			MainOnly,
			RemoteOnly,
			RemoteAsMainOnly
		}
	}
}
