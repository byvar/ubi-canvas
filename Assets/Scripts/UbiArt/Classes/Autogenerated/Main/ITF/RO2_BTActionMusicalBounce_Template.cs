using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionMusicalBounce_Template : BTActionPlayAnim_Template {
		public float amplitude;
		public float syncRatio;
		public float syncOffset;
		public bool updateMovement;
		public StringID musicalAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			amplitude = s.Serialize<float>(amplitude, name: "amplitude");
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
			updateMovement = s.Serialize<bool>(updateMovement, name: "updateMovement");
			musicalAnimation = s.SerializeObject<StringID>(musicalAnimation, name: "musicalAnimation");
		}
		public override uint? ClassCRC => 0x2CCB5012;
	}
}

