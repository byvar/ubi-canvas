using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_WM_PathComponent_Template : CSerializable {
		[Serialize("Path__0")] public Path Path__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
		}
		public override uint? ClassCRC => 0xB9958FCB;
	}
}

