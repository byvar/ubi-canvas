using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_217_sub_818240 : CSerializable {
		[Serialize("teamEnabled"    )] public int teamEnabled;
		[Serialize("teamMaxMember"  )] public uint teamMaxMember;
		[Serialize("scoreIsIn3D"    )] public int scoreIsIn3D;
		[Serialize("colorRayman"    )] public Color colorRayman;
		[Serialize("colorGlobox"    )] public Color colorGlobox;
		[Serialize("colorTeensy"    )] public Color colorTeensy;
		[Serialize("colorTeensyMago")] public Color colorTeensyMago;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(teamEnabled));
			SerializeField(s, nameof(teamMaxMember));
			SerializeField(s, nameof(scoreIsIn3D));
			SerializeField(s, nameof(colorRayman));
			SerializeField(s, nameof(colorGlobox));
			SerializeField(s, nameof(colorTeensy));
			SerializeField(s, nameof(colorTeensyMago));
		}
		public override uint? ClassCRC => 0x9B8A06A2;
	}
}

