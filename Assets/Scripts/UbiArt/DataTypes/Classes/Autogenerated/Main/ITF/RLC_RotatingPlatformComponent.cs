namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RotatingPlatformComponent : ActorComponent {
		public CArrayP<float> unreachableAngles;
		public bool clockwiseRotationLocked;
		public bool counterClockwiseRotationLocked;
		public bool playerActivationOnly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unreachableAngles = s.SerializeObject<CArrayP<float>>(unreachableAngles, name: "unreachableAngles");
			clockwiseRotationLocked = s.Serialize<bool>(clockwiseRotationLocked, name: "clockwiseRotationLocked");
			counterClockwiseRotationLocked = s.Serialize<bool>(counterClockwiseRotationLocked, name: "counterClockwiseRotationLocked");
			playerActivationOnly = s.Serialize<bool>(playerActivationOnly, name: "playerActivationOnly");
		}
		public override uint? ClassCRC => 0xEB17959E;
	}
}

