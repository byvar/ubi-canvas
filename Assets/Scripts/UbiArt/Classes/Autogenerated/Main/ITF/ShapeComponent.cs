using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class ShapeComponent : ActorComponent {
		[Serialize("localOffset"      )] public Vector2 localOffset;
		[Serialize("localScale"       )] public Vector2 localScale;
		[Serialize("useShapeTransform")] public bool useShapeTransform;
		[Serialize("AnimPolylineList" )] public CList<StringID> AnimPolylineList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(localOffset));
					SerializeField(s, nameof(localScale));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(useShapeTransform));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(localOffset));
					SerializeField(s, nameof(localScale));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(useShapeTransform), boolAsByte: true);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(localOffset));
					SerializeField(s, nameof(localScale));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(useShapeTransform));
				}
				SerializeField(s, nameof(AnimPolylineList));
			}
		}
		public override uint? ClassCRC => 0x43C597F1;
	}
}

