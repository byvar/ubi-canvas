using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LightningGeneratorAIComponent_Template : TimedSpawnerAIComponent_Template {
		[Serialize("pivotBoneName"      )] public StringID pivotBoneName;
		[Serialize("minAngle"           )] public Angle minAngle;
		[Serialize("maxAngle"           )] public Angle maxAngle;
		[Serialize("addOrientationInput")] public StringID addOrientationInput;
		[Serialize("dynamicOrientation" )] public bool dynamicOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pivotBoneName));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(addOrientationInput));
			SerializeField(s, nameof(dynamicOrientation));
		}
		public override uint? ClassCRC => 0x05978C64;
	}
}

