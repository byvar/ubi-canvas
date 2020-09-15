using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LevelIndicatorComponent : ActorComponent {
		public bool IsHelpMenuIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			IsHelpMenuIcon = s.Serialize<bool>(IsHelpMenuIcon, name: "IsHelpMenuIcon");
		}
		public override uint? ClassCRC => 0x6B34DD4F;
	}
}

