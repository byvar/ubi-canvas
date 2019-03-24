using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor {
		protected override void InitGameObject() {
			base.InitGameObject();
			foreach (Generic<ActorComponent> ac in COMPONENTS) {
				UnityActorComponentPlaceholder p = gao.AddComponent<UnityActorComponentPlaceholder>();
				p.name = ac.obj.GetType().Name;
			}
		}
	}
}
