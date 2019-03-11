using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionFishing_Template : BTAction_Template {
		[Serialize("animFishing" )] public StringID animFishing;
		[Serialize("animStopFish")] public StringID animStopFish;
		[Serialize("addSnapAngle")] public Angle addSnapAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animFishing));
			SerializeField(s, nameof(animStopFish));
			SerializeField(s, nameof(addSnapAngle));
		}
		public override uint? ClassCRC => 0x4E7367F4;
	}
}

