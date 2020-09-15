using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIMenuPageComponent : CSerializable {
		[Serialize("TriggerButton"        )] public uint TriggerButton;
		[Serialize("RelativePosFromCamera")] public Vec3d RelativePosFromCamera;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(TriggerButton));
				SerializeField(s, nameof(RelativePosFromCamera));
			}
		}
		public override uint? ClassCRC => 0x5E3B408B;
	}
}

