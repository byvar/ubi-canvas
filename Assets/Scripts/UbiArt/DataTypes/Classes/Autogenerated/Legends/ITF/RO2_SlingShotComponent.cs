namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SlingShotComponent : CSerializable {
		public int CanBeManipulatedAtStart;
		public int BlindControl;
		public float Sling_Size;
		public float Sling_GrabThreeshold;
		public float Sling_StretchOffset;
		public int Sling_NoBulletThrown;
		public float TimeToTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				CanBeManipulatedAtStart = s.Serialize<int>(CanBeManipulatedAtStart, name: "CanBeManipulatedAtStart");
				BlindControl = s.Serialize<int>(BlindControl, name: "BlindControl");
				Sling_Size = s.Serialize<float>(Sling_Size, name: "Sling_Size");
				Sling_GrabThreeshold = s.Serialize<float>(Sling_GrabThreeshold, name: "Sling_GrabThreeshold");
				Sling_StretchOffset = s.Serialize<float>(Sling_StretchOffset, name: "Sling_StretchOffset");
				Sling_NoBulletThrown = s.Serialize<int>(Sling_NoBulletThrown, name: "Sling_NoBulletThrown");
				TimeToTrigger = s.Serialize<float>(TimeToTrigger, name: "TimeToTrigger");
			}
		}
		public override uint? ClassCRC => 0xFEC34938;
	}
}

