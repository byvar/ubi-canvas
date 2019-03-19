using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_PowerUpManager_Template : CSerializable {
		[Serialize("uint__0")] public uint uint__0;
		[Serialize("uint__1")] public uint uint__1;
		[Serialize("uint__2")] public uint uint__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(uint__2));
		}
	}
}

