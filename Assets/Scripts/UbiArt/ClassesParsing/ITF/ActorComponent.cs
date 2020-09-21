using System.Collections.Generic;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorComponent {
		public virtual void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			UnityActorComponent uac = gao.AddComponent<UnityActorComponent>();
			uac.actor = act;
			uac.component = this;
		}
	}
}
