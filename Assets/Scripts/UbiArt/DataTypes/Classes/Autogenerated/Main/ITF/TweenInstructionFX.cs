namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class TweenInstructionFX : TweenInstruction {
		public ObjectPath target;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			target = s.SerializeObject<ObjectPath>(target, name: "target");
		}
		public override uint? ClassCRC => 0xCF6AFA8B;
	}
}

