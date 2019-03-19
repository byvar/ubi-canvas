using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LoadNotificationComponent_Template : CSerializable {
		[Serialize("animSize")] public Vector2 animSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animSize));
		}
		public override uint? ClassCRC => 0xD01F204E;
	}
}

