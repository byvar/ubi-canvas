using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepInteractionState_Template : CSerializable {
		public Placeholder id;
		public StringID state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<Placeholder>(id, name: "id");
			state = s.SerializeObject<StringID>(state, name: "state");
		}
		public override uint? ClassCRC => 0xFFE2E7F5;
	}
}

