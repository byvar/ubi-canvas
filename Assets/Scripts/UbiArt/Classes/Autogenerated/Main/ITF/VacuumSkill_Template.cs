using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class VacuumSkill_Template : CSerializable {
		[Serialize("PhysForceModifier__0")] public PhysForceModifier PhysForceModifier__0;
		[Serialize("float__1"            )] public float float__1;
		[Serialize("uint__2"             )] public uint uint__2;
		[Serialize("uint__3"             )] public uint uint__3;
		[Serialize("int__4"              )] public int int__4;
		[Serialize("float__5"            )] public float float__5;
		[Serialize("float__6"            )] public float float__6;
		[Serialize("float__7"            )] public float float__7;
		[Serialize("float__8"            )] public float float__8;
		[Serialize("float__9"            )] public float float__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(PhysForceModifier__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(uint__2));
			SerializeField(s, nameof(uint__3));
			SerializeField(s, nameof(int__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(float__9));
		}
	}
}

