namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_PlayerCostumeComponent_Template : ActorComponent_Template {
		public StringID usedAnim;
		public StringID nextAnim;
		public StringID lockedAnim;
		public StringID availableAnim;
		public StringID unlockAnim;
		public StringID changeFX;
		public Generic<PhysShape> pressUpShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			usedAnim = s.SerializeObject<StringID>(usedAnim, name: "usedAnim");
			nextAnim = s.SerializeObject<StringID>(nextAnim, name: "nextAnim");
			lockedAnim = s.SerializeObject<StringID>(lockedAnim, name: "lockedAnim");
			availableAnim = s.SerializeObject<StringID>(availableAnim, name: "availableAnim");
			unlockAnim = s.SerializeObject<StringID>(unlockAnim, name: "unlockAnim");
			changeFX = s.SerializeObject<StringID>(changeFX, name: "changeFX");
			pressUpShape = s.SerializeObject<Generic<PhysShape>>(pressUpShape, name: "pressUpShape");
		}
		public override uint? ClassCRC => 0x5EDC6B33;
	}
}

