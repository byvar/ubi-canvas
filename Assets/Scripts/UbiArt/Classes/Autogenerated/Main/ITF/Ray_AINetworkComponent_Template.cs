using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AINetworkComponent_Template : CSerializable {
		[Serialize("shape")] public Placeholder shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
		}
		public override uint? ClassCRC => 0x6D04E396;
	}
}

