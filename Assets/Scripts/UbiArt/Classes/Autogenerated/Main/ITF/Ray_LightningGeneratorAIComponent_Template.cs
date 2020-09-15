using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LightningGeneratorAIComponent_Template : TimedSpawnerAIComponent_Template {
		public StringID pivotBoneName;
		public Angle minAngle;
		public Angle maxAngle;
		public StringID addOrientationInput;
		public int dynamicOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pivotBoneName = s.SerializeObject<StringID>(pivotBoneName, name: "pivotBoneName");
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			addOrientationInput = s.SerializeObject<StringID>(addOrientationInput, name: "addOrientationInput");
			dynamicOrientation = s.Serialize<int>(dynamicOrientation, name: "dynamicOrientation");
		}
		public override uint? ClassCRC => 0x7563A31A;
	}
}

