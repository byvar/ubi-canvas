using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepInteractionState_Template : CSerializable {
		[Serialize("id"   )] public Placeholder id;
		[Serialize("state")] public StringID state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(state));
		}
		public override uint? ClassCRC => 0xFFE2E7F5;
	}
}

