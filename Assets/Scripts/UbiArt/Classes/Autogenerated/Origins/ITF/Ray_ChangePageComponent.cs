using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ChangePageComponent : CSerializable {
		[Serialize("finalDefaultPos")] public Vector2 finalDefaultPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(finalDefaultPos));
			}
		}
		public override uint? ClassCRC => 0x4EC45669;
	}
}

