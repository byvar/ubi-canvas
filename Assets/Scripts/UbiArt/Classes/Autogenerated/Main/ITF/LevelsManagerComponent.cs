using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class LevelsManagerComponent : ActorComponent {
		public float float__0;
		public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
		}
		public override uint? ClassCRC => 0x7025FF50;
	}
}

