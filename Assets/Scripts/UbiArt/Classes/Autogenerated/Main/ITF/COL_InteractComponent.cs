using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractComponent : CSerializable {
		[Serialize("triggerMode"       )] public Enum_triggerMode triggerMode;
		[Serialize("softSaveOnTrigger" )] public bool softSaveOnTrigger;
		[Serialize("triggered"         )] public int triggered;
		[Serialize("onInteractEvent"   )] public Placeholder onInteractEvent;
		[Serialize("onEndInteractEvent")] public Placeholder onEndInteractEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggerMode));
			SerializeField(s, nameof(softSaveOnTrigger), boolAsByte: true);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(triggered));
			}
			SerializeField(s, nameof(onInteractEvent));
			SerializeField(s, nameof(onEndInteractEvent));
		}
		public enum Enum_triggerMode {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x866ACAB9;
	}
}

