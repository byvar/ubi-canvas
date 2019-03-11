using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_257_sub_902FB0 : CSerializable {
		[Serialize("dbgSplineMaterial"                )] public Placeholder dbgSplineMaterial;
		[Serialize("shieldDragDistance"               )] public float shieldDragDistance;
		[Serialize("allowMultiPlayerMode"             )] public bool allowMultiPlayerMode;
		[Serialize("allowAutoGyroActivation"          )] public bool allowAutoGyroActivation;
		[Serialize("autoStartMode"                    )] public bool autoStartMode;
		[Serialize("multiPlayerActionValidationDelay" )] public float multiPlayerActionValidationDelay;
		[Serialize("multiPlayerManageTargetVisibility")] public bool multiPlayerManageTargetVisibility;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dbgSplineMaterial));
			SerializeField(s, nameof(shieldDragDistance));
			SerializeField(s, nameof(allowMultiPlayerMode));
			SerializeField(s, nameof(allowAutoGyroActivation));
			SerializeField(s, nameof(autoStartMode));
			SerializeField(s, nameof(multiPlayerActionValidationDelay));
			SerializeField(s, nameof(multiPlayerManageTargetVisibility));
		}
		public override uint? ClassCRC => 0xF7FD920D;
	}
}

