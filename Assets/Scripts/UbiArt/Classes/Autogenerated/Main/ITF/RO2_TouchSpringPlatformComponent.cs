using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchSpringPlatformComponent : RO2_TouchSpringPlatformBaseComponent {
		[Serialize("anchorData"       )] public RO2_TouchSpringPlatformComponent.AnchorDataStruct anchorData;
		[Serialize("calibrationParams")] public RO2_TouchSpringPlatformComponent.CalibrationParamsStruct calibrationParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(anchorData));
				SerializeField(s, nameof(calibrationParams));
			}
		}
		public partial class CalibrationParamsStruct : CSerializable {
			[Serialize("start"          )] public bool start;
			[Serialize("invertPivot"    )] public bool invertPivot;
			[Serialize("checkLinearMove")] public bool checkLinearMove;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(start));
				SerializeField(s, nameof(invertPivot));
				SerializeField(s, nameof(checkLinearMove));
			}
		}
		public partial class AnchorDataStruct : CSerializable {
			[Serialize("anchorRefBoneName")] public StringID anchorRefBoneName;
			[Serialize("pivotRefBoneName" )] public StringID pivotRefBoneName;
			[Serialize("pivotPos"         )] public Vector2 pivotPos;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(anchorRefBoneName));
				SerializeField(s, nameof(pivotRefBoneName));
				SerializeField(s, nameof(pivotPos));
			}
		}
		public override uint? ClassCRC => 0xFFF2FF90;
	}
}

