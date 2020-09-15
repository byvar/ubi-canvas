using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class EditableShape : CSerializable {
		public Generic<PhysShape> shape;
		public StringID bindedBoneName;
		public Vec2d localOffset;
		public bool applyRotation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
				if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
					bindedBoneName = s.SerializeObject<StringID>(bindedBoneName, name: "bindedBoneName");
					localOffset = s.SerializeObject<Vec2d>(localOffset, name: "localOffset");
					applyRotation = s.Serialize<bool>(applyRotation, name: "applyRotation");
				}
			}
		}
	}
}

