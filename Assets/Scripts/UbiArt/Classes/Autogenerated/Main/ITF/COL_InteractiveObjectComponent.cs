using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractiveObjectComponent : CSerializable {
		[Description("Default state of the object, is none is saved")]
		public StringID defaultObjectState;
		[Description("Current state of the object when saved")]
		public StringID savedObjectState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				defaultObjectState = s.SerializeObject<StringID>(defaultObjectState, name: "defaultObjectState");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				savedObjectState = s.SerializeObject<StringID>(savedObjectState, name: "savedObjectState");
			}
		}
		public override uint? ClassCRC => 0x550E7A52;
	}
}

