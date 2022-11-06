using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AINetworkComponent_Template : CSerializable {
		public Placeholder shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Placeholder>(shape, name: "shape");
		}
		public override uint? ClassCRC => 0x6D04E396;
	}
}

