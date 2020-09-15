using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LightningGeneratorAIComponent_Template : TimedSpawnerAIComponent_Template {
		public StringID pivotBoneName;
		public Angle minAngle;
		public Angle maxAngle;
		public StringID addOrientationInput;
		public bool dynamicOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pivotBoneName = s.SerializeObject<StringID>(pivotBoneName, name: "pivotBoneName");
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			addOrientationInput = s.SerializeObject<StringID>(addOrientationInput, name: "addOrientationInput");
			dynamicOrientation = s.Serialize<bool>(dynamicOrientation, name: "dynamicOrientation");
		}
		public override uint? ClassCRC => 0x05978C64;
	}
}

