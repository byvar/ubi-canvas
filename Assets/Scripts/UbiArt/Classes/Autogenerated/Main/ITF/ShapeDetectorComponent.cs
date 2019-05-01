using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ShapeDetectorComponent : DetectorComponent {
		[Serialize("localOffset"      )] public Vector2 localOffset;
		[Serialize("localScale"       )] public Vector2 localScale;
		[Serialize("useShapeTransform")] public bool useShapeTransform;
		[Serialize("useEditableShape" )] public bool useEditableShape;
		[Serialize("editableShape"    )] public EditableShape editableShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(localOffset));
					SerializeField(s, nameof(localScale));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(useShapeTransform));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(localOffset));
					SerializeField(s, nameof(localScale));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(useShapeTransform));
				}
				SerializeField(s, nameof(useEditableShape));
				SerializeField(s, nameof(editableShape));
			}
		}
		public override uint? ClassCRC => 0x6DD3B10F;
	}
}

