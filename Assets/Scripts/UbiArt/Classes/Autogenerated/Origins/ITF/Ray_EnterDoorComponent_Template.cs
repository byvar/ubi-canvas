using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EnterDoorComponent_Template : TriggerComponent_Template {
		[Serialize("entryPointId")] public StringID entryPointId;
		[Serialize("exitPointId" )] public StringID exitPointId;
		[Serialize("noEntry"     )] public bool noEntry;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(entryPointId));
			SerializeField(s, nameof(exitPointId));
			SerializeField(s, nameof(noEntry));
		}
		public override uint? ClassCRC => 0x7A16849A;
	}
}

