using UnityEngine;

namespace UbiArt.ITF {
	public partial class Trail3DComponent_Template : GraphicComponent_Template {
		[Serialize("trailList"  )] public CList<Trail_Template> trailList;
		[Serialize("startActive")] public bool startActive;
		[Serialize("draw2D"     )] public bool draw2D;
		[Serialize("fixDepth"   )] public bool fixDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(trailList));
				SerializeField(s, nameof(startActive));
				SerializeField(s, nameof(draw2D));
			} else {
				SerializeField(s, nameof(trailList));
				SerializeField(s, nameof(startActive));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(fixDepth));
			}
		}
		public override uint? ClassCRC => 0xC58BDE47;
	}
}

