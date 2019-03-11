using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LevelIndicatorComponent : ActorComponent {
		[Serialize("IsHelpMenuIcon")] public bool IsHelpMenuIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(IsHelpMenuIcon));
		}
		public override uint? ClassCRC => 0x6B34DD4F;
	}
}

