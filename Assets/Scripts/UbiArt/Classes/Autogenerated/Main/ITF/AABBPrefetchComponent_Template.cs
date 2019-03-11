using UnityEngine;

namespace UbiArt.ITF {
	public partial class AABBPrefetchComponent_Template : ActorComponent_Template {
		[Serialize("isAlwaysActive")] public bool isAlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isAlwaysActive));
		}
		public override uint? ClassCRC => 0x70B3ABBA;
	}
}

