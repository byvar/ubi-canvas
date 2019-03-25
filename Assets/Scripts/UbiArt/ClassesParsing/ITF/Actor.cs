using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor {
		protected override void InitGameObject() {
			base.InitGameObject();
			if (this is Frise) return;
			foreach (Generic<ActorComponent> ac in COMPONENTS) {
				UnityActorComponentPlaceholder p = gao.AddComponent<UnityActorComponentPlaceholder>();
				p.componentName = ac.obj.GetType().Name;
			}
		}
	}
}
