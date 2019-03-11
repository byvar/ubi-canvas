using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DestroyComponent_Template : ActorComponent_Template {
		[Serialize("waitForFx"        )] public bool waitForFx;
		[Serialize("timeBeforeDestroy")] public float timeBeforeDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitForFx));
			SerializeField(s, nameof(timeBeforeDestroy));
		}
		public override uint? ClassCRC => 0x22C1A57D;
	}
}

