using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventGotoRequest : Event {
		[Serialize("gotoRequestType"   )] public Enum_gotoRequestType gotoRequestType;
		[Serialize("gotoTargetObject"  )] public Placeholder gotoTargetObject;
		[Serialize("gotoTargetPosition")] public Vector2 gotoTargetPosition;
		[Serialize("gotoDuration"      )] public float gotoDuration;
		[Serialize("run"               )] public bool run;
		[Serialize("startOnGround"     )] public bool startOnGround;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gotoRequestType));
			SerializeField(s, nameof(gotoTargetObject));
			SerializeField(s, nameof(gotoTargetPosition));
			SerializeField(s, nameof(gotoDuration));
			SerializeField(s, nameof(run), boolAsByte: true);
			SerializeField(s, nameof(startOnGround), boolAsByte: true);
		}
		public enum Enum_gotoRequestType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x9323E6CE;
	}
}

