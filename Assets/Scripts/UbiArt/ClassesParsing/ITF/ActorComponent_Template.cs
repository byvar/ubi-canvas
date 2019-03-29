using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorComponent_Template {
		public virtual void InitUnityComponent(Actor act, Actor_Template tpl, GameObject gao, int index) {
			UnityActorComponentTemplate uac = gao.AddComponent<UnityActorComponentTemplate>();
			uac.actor = act;
			uac.template = tpl;
			uac.component = this;
		}
	}
}
