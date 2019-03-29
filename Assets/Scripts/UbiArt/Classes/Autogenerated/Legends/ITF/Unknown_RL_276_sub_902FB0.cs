using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_276_sub_902FB0 : ActorComponent_Template {
		[Serialize("dbgSplineMaterial"                )] public GFXMaterialSerializable dbgSplineMaterial;
		[Serialize("shieldDragDistance"               )] public float shieldDragDistance;
		[Serialize("allowMultiPlayerMode"             )] public int allowMultiPlayerMode;
		[Serialize("allowAutoGyroActivation"          )] public int allowAutoGyroActivation;
		[Serialize("autoStartMode"                    )] public int autoStartMode;
		[Serialize("multiPlayerActionValidationDelay" )] public float multiPlayerActionValidationDelay;
		[Serialize("multiPlayerManageTargetVisibility")] public int multiPlayerManageTargetVisibility;
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

