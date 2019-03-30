using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor {
		public GenericFile<Actor_Template> template;
		
		protected override void InitGameObject() {
			base.InitGameObject();
			if (Settings.s.game != Settings.Game.RA && this is Frise) return;
			for(int i = 0; i < COMPONENTS.Count; i++) {
				Generic<ActorComponent> ac = COMPONENTS[i];
				if (ac != null && !ac.IsNull) {
					ac.obj.InitUnityComponent(this, gao, i);
				}
			}
			if (template != null && template.obj != null) {
				for (int i = 0; i < template.obj.COMPONENTS.Count; i++) {
					Generic<ActorComponent_Template> ac = template.obj.COMPONENTS[i];
					if (ac != null && !ac.IsNull) {
						ac.obj.InitUnityComponent(this, template.obj, gao, i);
					}
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
						extS.log = l.logEnabled;
						extS.Serialize(ref template);
						l.tpl[LUA.stringID] = template;
					}
				});
			}
		}
	}
}
