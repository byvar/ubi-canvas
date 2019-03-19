using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WorldMapUIItem : CSerializable {
		[Description("Map Location StringID.")]
		[Serialize("mapLocationID")] public StringID mapLocationID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mapLocationID));
		}
		public override uint? ClassCRC => 0xB2547578;
	}
}

