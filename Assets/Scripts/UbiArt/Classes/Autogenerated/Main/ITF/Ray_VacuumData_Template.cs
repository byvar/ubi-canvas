using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_VacuumData_Template : CSerializable {
		[Serialize("int__0"  )] public int int__0;
		[Serialize("float__1")] public float float__1;
		[Serialize("float__2")] public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
		}
	}
}

