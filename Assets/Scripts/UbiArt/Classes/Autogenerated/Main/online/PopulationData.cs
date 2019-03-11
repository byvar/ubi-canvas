using UnityEngine;

namespace UbiArt.online {
	public partial class PopulationData : CSerializable {
		[Serialize("populations"       )] public CMap<ITF.StringID, Population> populations;
		[Serialize("deletedPopulations")] public CArray<StringID> deletedPopulations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(populations));
			SerializeField(s, nameof(deletedPopulations));
		}
		public override uint? ClassCRC => 0xAE1EAD54;
	}
}

