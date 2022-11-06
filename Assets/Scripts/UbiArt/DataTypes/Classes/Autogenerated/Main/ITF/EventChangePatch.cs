using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventChangePatch : Event {
		public bool Clear;
		public StringID BoneId;
		public StringID PatchId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Clear = s.Serialize<bool>(Clear, name: "Clear");
			BoneId = s.SerializeObject<StringID>(BoneId, name: "BoneId");
			PatchId = s.SerializeObject<StringID>(PatchId, name: "PatchId");
		}
		public override uint? ClassCRC => 0x853EE19D;
	}
}

