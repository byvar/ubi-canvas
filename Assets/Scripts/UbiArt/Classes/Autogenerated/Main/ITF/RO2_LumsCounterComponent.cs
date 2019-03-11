using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LumsCounterComponent : ActorComponent {
		[Serialize("IsHelpMenuIcon")] public bool IsHelpMenuIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(IsHelpMenuIcon));
		}
		public override uint? ClassCRC => 0x9CF92AE1;
	}
}

