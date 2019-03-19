using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Pad2Touch : ActorComponent {
		[Serialize("OffSet"      )] public Vector2 OffSet;
		[Serialize("viewportName")] public string viewportName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OffSet));
			SerializeField(s, nameof(viewportName));
		}
		public override uint? ClassCRC => 0x2117995D;
	}
}

