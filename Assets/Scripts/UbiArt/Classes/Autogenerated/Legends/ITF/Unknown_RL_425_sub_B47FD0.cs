using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_425_sub_B47FD0 : CSerializable {
		[Serialize("CanBeManipulatedAtStart")] public int CanBeManipulatedAtStart;
		[Serialize("BlindControl"           )] public int BlindControl;
		[Serialize("Sling_Size"             )] public float Sling_Size;
		[Serialize("Sling_GrabThreeshold"   )] public float Sling_GrabThreeshold;
		[Serialize("Sling_StretchOffset"    )] public float Sling_StretchOffset;
		[Serialize("Sling_NoBulletThrown"   )] public int Sling_NoBulletThrown;
		[Serialize("TimeToTrigger"          )] public float TimeToTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(CanBeManipulatedAtStart));
				SerializeField(s, nameof(BlindControl));
				SerializeField(s, nameof(Sling_Size));
				SerializeField(s, nameof(Sling_GrabThreeshold));
				SerializeField(s, nameof(Sling_StretchOffset));
				SerializeField(s, nameof(Sling_NoBulletThrown));
				SerializeField(s, nameof(TimeToTrigger));
			}
		}
		public override uint? ClassCRC => 0xFEC34938;
	}
}

