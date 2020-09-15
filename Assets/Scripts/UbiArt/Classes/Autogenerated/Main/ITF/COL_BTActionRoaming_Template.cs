using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRoaming_Template : CSerializable {
		public StringID name;
		public StringID animWalk;
		public StringID animUTurn;
		public StringID animIdle;
		public float idleDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			animWalk = s.SerializeObject<StringID>(animWalk, name: "animWalk");
			animUTurn = s.SerializeObject<StringID>(animUTurn, name: "animUTurn");
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			idleDuration = s.Serialize<float>(idleDuration, name: "idleDuration");
		}
		public override uint? ClassCRC => 0x8FF18741;
	}
}

