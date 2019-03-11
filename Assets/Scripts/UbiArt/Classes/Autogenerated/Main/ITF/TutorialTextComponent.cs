using UnityEngine;

namespace UbiArt.ITF {
	public partial class TutorialTextComponent : ActorComponent {
		[Serialize("RELATIVEPOS")] public Vector2 RELATIVEPOS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(RELATIVEPOS));
			}
		}
		public override uint? ClassCRC => 0x92A7EA4E;
	}
}

