using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class HUDTouch : ActorComponent {
		public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
		}
		public override uint? ClassCRC => 0x798DB946;
	}
}

