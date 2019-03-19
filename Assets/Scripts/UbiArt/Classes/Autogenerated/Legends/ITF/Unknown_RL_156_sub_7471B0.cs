using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_156_sub_7471B0 : CSerializable {
		[Serialize("colorFactorSelected"  )] public Color colorFactorSelected;
		[Serialize("colorFactorUnselected")] public Color colorFactorUnselected;
		[Serialize("medalColorAlphaFactor")] public float medalColorAlphaFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(colorFactorSelected));
			SerializeField(s, nameof(colorFactorUnselected));
			SerializeField(s, nameof(medalColorAlphaFactor));
		}
		public override uint? ClassCRC => 0xD6DA9C05;
	}
}

