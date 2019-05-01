using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangePageComponent : ActorComponent {
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

