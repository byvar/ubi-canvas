using UnityEngine;

namespace UbiArt.ITF {
	public partial class FactionComponent_Template : ActorComponent_Template {
		[Serialize("faction")] public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
		}
		public override uint? ClassCRC => 0xCBB4C235;
	}
}

