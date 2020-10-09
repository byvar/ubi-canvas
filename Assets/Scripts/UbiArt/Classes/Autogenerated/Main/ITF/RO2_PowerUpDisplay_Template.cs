using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PowerUpDisplay_Template : CSerializable {
		public StringID id;
		public string debugName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				id = s.SerializeObject<StringID>(id, name: "id");
			} else {
				id = s.SerializeObject<StringID>(id, name: "id");
				debugName = s.Serialize<string>(debugName, name: "debugName");
			}
		}
		public override uint? ClassCRC => 0x41C1630D;
	}
}

