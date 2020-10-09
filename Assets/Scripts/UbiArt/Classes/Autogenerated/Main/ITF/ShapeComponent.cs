using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class ShapeComponent : ActorComponent {
		public Vec2d localOffset;
		public Vec2d localScale;
		public bool useShapeTransform;
		public CListO<StringID> AnimPolylineList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					localOffset = s.SerializeObject<Vec2d>(localOffset, name: "localOffset");
					localScale = s.SerializeObject<Vec2d>(localScale, name: "localScale");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					useShapeTransform = s.Serialize<bool>(useShapeTransform, name: "useShapeTransform");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					localOffset = s.SerializeObject<Vec2d>(localOffset, name: "localOffset");
					localScale = s.SerializeObject<Vec2d>(localScale, name: "localScale");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					useShapeTransform = s.Serialize<bool>(useShapeTransform, name: "useShapeTransform", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					localOffset = s.SerializeObject<Vec2d>(localOffset, name: "localOffset");
					localScale = s.SerializeObject<Vec2d>(localScale, name: "localScale");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					useShapeTransform = s.Serialize<bool>(useShapeTransform, name: "useShapeTransform");
				}
				AnimPolylineList = s.SerializeObject<CListO<StringID>>(AnimPolylineList, name: "AnimPolylineList");
			}
		}
		public override uint? ClassCRC => 0x43C597F1;
	}
}

