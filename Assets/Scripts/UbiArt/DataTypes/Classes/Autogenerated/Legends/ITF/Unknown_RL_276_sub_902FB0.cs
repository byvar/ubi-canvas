namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_276_sub_902FB0 : ActorComponent_Template {
		public GFXMaterialSerializable dbgSplineMaterial;
		public float shieldDragDistance;
		public int allowMultiPlayerMode;
		public int allowAutoGyroActivation;
		public int autoStartMode;
		public float multiPlayerActionValidationDelay;
		public int multiPlayerManageTargetVisibility;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dbgSplineMaterial = s.SerializeObject<GFXMaterialSerializable>(dbgSplineMaterial, name: "dbgSplineMaterial");
			shieldDragDistance = s.Serialize<float>(shieldDragDistance, name: "shieldDragDistance");
			allowMultiPlayerMode = s.Serialize<int>(allowMultiPlayerMode, name: "allowMultiPlayerMode");
			allowAutoGyroActivation = s.Serialize<int>(allowAutoGyroActivation, name: "allowAutoGyroActivation");
			autoStartMode = s.Serialize<int>(autoStartMode, name: "autoStartMode");
			multiPlayerActionValidationDelay = s.Serialize<float>(multiPlayerActionValidationDelay, name: "multiPlayerActionValidationDelay");
			multiPlayerManageTargetVisibility = s.Serialize<int>(multiPlayerManageTargetVisibility, name: "multiPlayerManageTargetVisibility");
		}
		public override uint? ClassCRC => 0xF7FD920D;
	}
}

