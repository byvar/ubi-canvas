using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeBodyPartAmvRenderer_Template : RO2_SnakeBodyPartRenderer_Template {
		public StringID anim;
		public uint startFrame;
		public Vec2d scale;
		public Color color;
		public CListO<Vec2d> polyline;
		public CListO<Vec2d> otherPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				startFrame = s.Serialize<uint>(startFrame, name: "startFrame");
				scale = s.SerializeObject<Vec2d>(scale, name: "scale");
				color = s.SerializeObject<Color>(color, name: "color");
				polyline = s.SerializeObject<CListO<Vec2d>>(polyline, name: "polyline");
				otherPolyline = s.SerializeObject<CListO<Vec2d>>(otherPolyline, name: "otherPolyline");
			} else {
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				startFrame = s.Serialize<uint>(startFrame, name: "startFrame");
				scale = s.SerializeObject<Vec2d>(scale, name: "scale");
				color = s.SerializeObject<Color>(color, name: "color");
			}
		}
		public override uint? ClassCRC => 0x257E9550;
	}
}

