using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbComponent : CSerializable {
		[Serialize("orbCount")] public float orbCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(orbCount));
		}
		public override uint? ClassCRC => 0xA5478EE5;
	}
}

