using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UIGemsCountComponent_Template : UIComponent_Template {
		[Serialize("rubyPath"      )] public Path rubyPath;
		[Serialize("travelDuration")] public float travelDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rubyPath));
			SerializeField(s, nameof(travelDuration));
		}
		public override uint? ClassCRC => 0x18E26CA6;
	}
}

