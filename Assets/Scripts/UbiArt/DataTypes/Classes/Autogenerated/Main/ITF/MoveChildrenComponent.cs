using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MoveChildrenComponent : ActorComponent {
		public bool isActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isActive = s.Serialize<bool>(isActive, name: "isActive");
		}
		public override uint? ClassCRC => 0x83124BA2;
	}
}

