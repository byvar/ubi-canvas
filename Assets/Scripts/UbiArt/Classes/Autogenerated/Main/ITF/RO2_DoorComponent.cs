using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DoorComponent : ActorComponent {
		[Serialize("detectRange"     )] public float detectRange;
		[Serialize("automaticOpening")] public bool automaticOpening;
		[Serialize("openCursor"      )] public float openCursor;
		[Serialize("isLocked"        )] public bool isLocked;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(detectRange));
				SerializeField(s, nameof(automaticOpening));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(openCursor));
				SerializeField(s, nameof(isLocked));
			}
		}
		public override uint? ClassCRC => 0x45E0160D;
	}
}

