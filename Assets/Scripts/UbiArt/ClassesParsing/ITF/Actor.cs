using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor {
		protected override void InitGameObject() {
			base.InitGameObject();
			if (this is Frise) return;
			foreach (Generic<ActorComponent> ac in COMPONENTS) {
				UnityActorComponent uac = gao.AddComponent<UnityActorComponent>();
				uac.actor = this;
				uac.component = ac;
			}
		}
	}
}
