using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionWaitForDanceOnDoor_Template : CSerializable {
		[Serialize("anim"      )] public StringID anim;
		[Serialize("syncRatio" )] public float syncRatio;
		[Serialize("syncOffset")] public float syncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(syncRatio));
			SerializeField(s, nameof(syncOffset));
		}
		public override uint? ClassCRC => 0x7F26FDB1;
	}
}

