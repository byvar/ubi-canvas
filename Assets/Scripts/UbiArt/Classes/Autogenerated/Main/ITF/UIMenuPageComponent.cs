using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIMenuPageComponent : CSerializable {
		public uint TriggerButton;
		public Vec3d RelativePosFromCamera;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				TriggerButton = s.Serialize<uint>(TriggerButton, name: "TriggerButton");
				RelativePosFromCamera = s.SerializeObject<Vec3d>(RelativePosFromCamera, name: "RelativePosFromCamera");
			}
		}
		public override uint? ClassCRC => 0x5E3B408B;
	}
}

