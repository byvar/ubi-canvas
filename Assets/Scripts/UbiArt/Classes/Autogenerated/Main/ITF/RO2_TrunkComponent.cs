using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TrunkComponent : ActorComponent {
		[Serialize("max"                   )] public Vector2 max;
		[Serialize("heightUnderLeftCorner" )] public float heightUnderLeftCorner;
		[Serialize("heightUnderRightCorner")] public float heightUnderRightCorner;
		[Serialize("hookLengthLeft"        )] public float hookLengthLeft;
		[Serialize("hookLengthRight"       )] public float hookLengthRight;
		[Serialize("onlyOneTrigger"        )] public bool onlyOneTrigger;
		[Serialize("setUpEnabled"          )] public bool setUpEnabled;
		[Serialize("osciSummitHeight"      )] public float osciSummitHeight;
		[Serialize("osciAngularAccel"      )] public Angle osciAngularAccel;
		[Serialize("osciAngularSpeedInit"  )] public Angle osciAngularSpeedInit;
		[Serialize("acceptCheckPointSave"  )] public bool acceptCheckPointSave;
		[Serialize("cornerLowerLeft"       )] public RO2_TrunkComponent.RO2_TrunkCorner cornerLowerLeft;
		[Serialize("cornerLowerRight"      )] public RO2_TrunkComponent.RO2_TrunkCorner cornerLowerRight;
		[Serialize("cornerUpperLeft"       )] public RO2_TrunkComponent.RO2_TrunkCorner cornerUpperLeft;
		[Serialize("cornerUpperRight"      )] public RO2_TrunkComponent.RO2_TrunkCorner cornerUpperRight;
		[Serialize("checkpointAngle"       )] public float checkpointAngle;
		[Serialize("checkpointPos"         )] public Vector2 checkpointPos;
		[Serialize("isStill"               )] public bool isStill;
		[Serialize("trunkIsStoped"         )] public bool trunkIsStoped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(heightUnderLeftCorner));
				SerializeField(s, nameof(heightUnderRightCorner));
				SerializeField(s, nameof(hookLengthLeft));
				SerializeField(s, nameof(hookLengthRight));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(onlyOneTrigger));
					SerializeField(s, nameof(setUpEnabled));
					SerializeField(s, nameof(osciSummitHeight));
					SerializeField(s, nameof(osciAngularAccel));
					SerializeField(s, nameof(osciAngularSpeedInit));
					SerializeField(s, nameof(acceptCheckPointSave));
				}
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(cornerLowerLeft));
				SerializeField(s, nameof(cornerLowerRight));
				SerializeField(s, nameof(cornerUpperLeft));
				SerializeField(s, nameof(cornerUpperRight));
				SerializeField(s, nameof(checkpointAngle));
				SerializeField(s, nameof(checkpointPos));
				SerializeField(s, nameof(isStill));
				SerializeField(s, nameof(trunkIsStoped));
			}
		}
		public partial class RO2_TrunkCorner : CSerializable {
			[Serialize("localPos"    )] public Vector2 localPos;
			[Serialize("isPined"     )] public bool isPined;
			[Serialize("angularSpeed")] public Angle angularSpeed;
			[Serialize("isInCol"     )] public bool isInCol;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(localPos));
				SerializeField(s, nameof(isPined));
				SerializeField(s, nameof(angularSpeed));
				SerializeField(s, nameof(isInCol));
			}
		}
		public override uint? ClassCRC => 0xB40A3FAA;
	}
}

