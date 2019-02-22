using ITF.ActorComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SubSceneActor : Actor {
		public Path relativePath;
		public bool embedScene;
		public bool isSinglePiece;
		public bool zForced;
		public bool directPicking;
		public ViewType viewType;
		public Scene scene;

		protected override void InitGameObject() {
			base.InitGameObject();
			foreach (Frise f in scene.frise) {
				f.Gao.transform.SetParent(gao.transform);
			}
			foreach (Actor a in scene.actors) {
				a.Gao.transform.SetParent(gao.transform);
			}
		}

		public SubSceneActor(Reader reader) : base(reader) {
			relativePath = new Path(reader);
			embedScene = reader.ReadBoolean();
			isSinglePiece = reader.ReadBoolean();
			zForced = reader.ReadBoolean();
			directPicking = reader.ReadBoolean();
			viewType = (ViewType)reader.ReadUInt32();
			if (reader.ReadBoolean()) scene = new Scene(reader);
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
