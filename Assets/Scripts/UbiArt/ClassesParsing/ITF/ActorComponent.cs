using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorComponent {
		public virtual void InitUnityComponent(Actor act, GameObject gao, int index) {
			UnityActorComponent uac = gao.AddComponent<UnityActorComponent>();
			uac.actor = act;
			uac.component = this;
		}
	}
}
