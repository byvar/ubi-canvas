using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeBodyPartAmvRenderer_Template : RO2_SnakeBodyPartRenderer_Template {
		[Serialize("anim"         )] public StringID anim;
		[Serialize("startFrame"   )] public uint startFrame;
		[Serialize("scale"        )] public Vec2d scale;
		[Serialize("color"        )] public Color color;
		[Serialize("polyline"     )] public CList<Vec2d> polyline;
		[Serialize("otherPolyline")] public CList<Vec2d> otherPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(startFrame));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(polyline));
				SerializeField(s, nameof(otherPolyline));
			} else {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(startFrame));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(color));
			}
		}
		public override uint? ClassCRC => 0x257E9550;
	}
}

