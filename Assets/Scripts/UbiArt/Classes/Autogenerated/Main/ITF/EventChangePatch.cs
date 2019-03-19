using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventChangePatch : Event {
		[Serialize("Clear"  )] public bool Clear;
		[Serialize("BoneId" )] public StringID BoneId;
		[Serialize("PatchId")] public StringID PatchId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Clear));
			SerializeField(s, nameof(BoneId));
			SerializeField(s, nameof(PatchId));
		}
		public override uint? ClassCRC => 0x853EE19D;
	}
}

