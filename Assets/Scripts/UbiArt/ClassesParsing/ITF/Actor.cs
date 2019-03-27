using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor {
		protected override void InitGameObject() {
			base.InitGameObject();
			if (this is Frise) return;
			foreach (Generic<ActorComponent> ac in COMPONENTS) {
				if (ac != null && !ac.IsNull) {
					ac.obj.InitUnityComponent(this, gao);
				}
			}
		}
	}
}
