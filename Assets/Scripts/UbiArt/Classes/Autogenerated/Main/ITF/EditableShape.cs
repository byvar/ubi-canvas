using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class EditableShape : CSerializable {
		[Serialize("shape")] public Generic<PhysShape> shape;
		[Serialize("bindedBoneName")] public StringID bindedBoneName;
		[Serialize("localOffset"   )] public Vector2 localOffset;
		[Serialize("applyRotation" )] public bool applyRotation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(shape));
				if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
					SerializeField(s, nameof(bindedBoneName));
					SerializeField(s, nameof(localOffset));
					SerializeField(s, nameof(applyRotation));
				}
			}
		}
	}
}

