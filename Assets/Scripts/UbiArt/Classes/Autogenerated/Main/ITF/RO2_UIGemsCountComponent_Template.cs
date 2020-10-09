using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_UIGemsCountComponent_Template : UIComponent_Template {
		public Path rubyPath;
		public float travelDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rubyPath = s.SerializeObject<Path>(rubyPath, name: "rubyPath");
			travelDuration = s.Serialize<float>(travelDuration, name: "travelDuration");
		}
		public override uint? ClassCRC => 0x18E26CA6;
	}
}

