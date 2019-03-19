using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_LumSpawnerComponent : ActorComponent {
		[Serialize("nbLums"     )] public uint nbLums;
		[Serialize("isRed"      )] public bool isRed;
		[Serialize("triggerOnce")] public bool triggerOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nbLums));
			SerializeField(s, nameof(isRed));
			SerializeField(s, nameof(triggerOnce));
		}
		public override uint? ClassCRC => 0x43CBBD0B;
	}
}

