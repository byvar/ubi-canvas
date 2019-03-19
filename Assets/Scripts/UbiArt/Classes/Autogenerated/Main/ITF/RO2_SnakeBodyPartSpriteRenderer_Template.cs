using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeBodyPartSpriteRenderer_Template : RO2_SnakeBodyPartRenderer_Template {
		[Serialize("anim"         )] public AnimationAtlas anim;
		[Serialize("drawAABB"     )] public AABB drawAABB;
		[Serialize("color"        )] public Color color;
		[Serialize("polyline"     )] public Placeholder polyline;
		[Serialize("otherPolyline")] public Placeholder otherPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(drawAABB));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(polyline));
				SerializeField(s, nameof(otherPolyline));
			} else {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(drawAABB));
				SerializeField(s, nameof(color));
			}
		}
		public override uint? ClassCRC => 0x56D9502D;
	}
}

