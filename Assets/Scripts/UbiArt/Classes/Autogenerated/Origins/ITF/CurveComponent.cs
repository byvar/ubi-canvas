using UnityEngine;

namespace UbiArt.ITF {
	public partial class CurveComponent : CSerializable {
		[Serialize("points")] public Placeholder points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(points));
			}
		}
		public override uint? ClassCRC => 0x4BBCC846;
	}
}

