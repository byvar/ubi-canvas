using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_63_sub_9456B0 : CSerializable {
		[Serialize("playBlockOnce"          )] public bool playBlockOnce;
		[Serialize("nbPartPlayed"           )] public uint nbPartPlayed;
		[Serialize("startingPart"           )] public uint startingPart;
		[Serialize("partList"               )] public Placeholder partList;
		[Serialize("keepPositionBetweenPlay")] public bool keepPositionBetweenPlay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playBlockOnce));
			SerializeField(s, nameof(nbPartPlayed));
			SerializeField(s, nameof(startingPart));
			SerializeField(s, nameof(partList));
			SerializeField(s, nameof(keepPositionBetweenPlay));
		}
		public override uint? ClassCRC => 0x9AB69974;
	}
}

