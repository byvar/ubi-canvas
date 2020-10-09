using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class TweenRenderComponent_Template : GraphicComponent_Template {
		public Trail_Template trail;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			trail = s.SerializeObject<Trail_Template>(trail, name: "trail");
		}
		public override uint? ClassCRC => 0x117F0373;
	}
}

