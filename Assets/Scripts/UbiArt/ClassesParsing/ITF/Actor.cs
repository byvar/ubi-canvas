using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor {
		public GenericFile<Actor_Template> template;
		
		protected override void InitGameObject() {
			base.InitGameObject();
			if (Settings.s.game != Settings.Game.RA && this is Frise) return;
			foreach (Generic<ActorComponent> ac in COMPONENTS) {
				if (ac != null && !ac.IsNull) {
					ac.obj.InitUnityComponent(this, gao);
				}
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (Settings.s.game != Settings.Game.RA && this is Frise) return;
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(LUA, (extS) => {
					if (l.tpl.ContainsKey(LUA.stringID)) {
						template = l.tpl[LUA.stringID];
					} else {
						extS.log = true;
						extS.Serialize(ref template);
						l.tpl[LUA.stringID] = template;
						l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
					}
				});
			}
		}
	}
}
