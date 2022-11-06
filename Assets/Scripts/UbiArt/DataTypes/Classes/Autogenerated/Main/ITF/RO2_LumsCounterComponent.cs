using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LumsCounterComponent : ActorComponent {
		public bool IsHelpMenuIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			IsHelpMenuIcon = s.Serialize<bool>(IsHelpMenuIcon, name: "IsHelpMenuIcon");
		}
		public override uint? ClassCRC => 0x9CF92AE1;
	}
}

