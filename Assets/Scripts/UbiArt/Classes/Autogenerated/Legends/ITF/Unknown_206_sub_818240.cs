using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_206_sub_818240 : CSerializable {
		[Serialize("teamEnabled"    )] public bool teamEnabled;
		[Serialize("teamMaxMember"  )] public uint teamMaxMember;
		[Serialize("scoreIsIn3D"    )] public bool scoreIsIn3D;
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

