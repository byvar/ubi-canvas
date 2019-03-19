using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class LevelsManagerComponent : ActorComponent {
		[Serialize("float__0")] public float float__0;
		[Serialize("bool__1" )] public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(bool__1));
		}
		public override uint? ClassCRC => 0x7025FF50;
	}
}

