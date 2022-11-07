namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DeadGuyBTAIComponent_Template : BTAIComponent_Template {
		public uint maxTeeth;
		public float getTeethSequenceDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxTeeth = s.Serialize<uint>(maxTeeth, name: "maxTeeth");
			getTeethSequenceDistance = s.Serialize<float>(getTeethSequenceDistance, name: "getTeethSequenceDistance");
		}
		public override uint? ClassCRC => 0x7F67FAC7;
	}
}

