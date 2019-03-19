using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractiveObjectComponent : CSerializable {
		[Description("Default state of the object, is none is saved")]
		[Serialize("defaultObjectState")] public StringID defaultObjectState;
		[Description("Current state of the object when saved")]
		[Serialize("savedObjectState"  )] public StringID savedObjectState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(defaultObjectState));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(savedObjectState));
			}
		}
		public override uint? ClassCRC => 0x550E7A52;
	}
}

