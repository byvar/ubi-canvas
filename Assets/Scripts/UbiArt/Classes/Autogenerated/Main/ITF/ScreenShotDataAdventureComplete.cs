using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataAdventureComplete : online.OpenGraphObject {
		[Serialize("cur_adv_seq")] public uint cur_adv_seq;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cur_adv_seq));
		}
		public override uint? ClassCRC => 0xFEDB8477;
	}
}

