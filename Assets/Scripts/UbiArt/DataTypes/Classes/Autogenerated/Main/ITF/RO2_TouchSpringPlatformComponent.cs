using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchSpringPlatformComponent : RO2_TouchSpringPlatformBaseComponent {
		public RO2_TouchSpringPlatformComponent.AnchorDataStruct anchorData;
		public RO2_TouchSpringPlatformComponent.CalibrationParamsStruct calibrationParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				anchorData = s.SerializeObject<RO2_TouchSpringPlatformComponent.AnchorDataStruct>(anchorData, name: "anchorData");
				calibrationParams = s.SerializeObject<RO2_TouchSpringPlatformComponent.CalibrationParamsStruct>(calibrationParams, name: "calibrationParams");
			}
		}
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class CalibrationParamsStruct : CSerializable {
			public bool start;
			public bool invertPivot;
			public bool checkLinearMove;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.Settings.game == Settings.Game.RL) {
					start = s.Serialize<bool>(start, name: "start", options: CSerializerObject.Options.BoolAsByte);
					invertPivot = s.Serialize<bool>(invertPivot, name: "invertPivot", options: CSerializerObject.Options.BoolAsByte);
					checkLinearMove = s.Serialize<bool>(checkLinearMove, name: "checkLinearMove", options: CSerializerObject.Options.BoolAsByte);
				} else {
					start = s.Serialize<bool>(start, name: "start");
					invertPivot = s.Serialize<bool>(invertPivot, name: "invertPivot");
					checkLinearMove = s.Serialize<bool>(checkLinearMove, name: "checkLinearMove");
				}
			}
		}
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class AnchorDataStruct : CSerializable {
			public StringID anchorRefBoneName;
			public StringID pivotRefBoneName;
			public Vec2d pivotPos;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				anchorRefBoneName = s.SerializeObject<StringID>(anchorRefBoneName, name: "anchorRefBoneName");
				pivotRefBoneName = s.SerializeObject<StringID>(pivotRefBoneName, name: "pivotRefBoneName");
				if (pivotRefBoneName == null || pivotRefBoneName.IsNull) {
					pivotPos = s.SerializeObject<Vec2d>(pivotPos, name: "pivotPos");
				}
			}
		}
		public override uint? ClassCRC => 0xFFF2FF90;
	}
}

