using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_74_sub_9456B0 : MusicTreeNode_Template {
		[Serialize("playBlockOnce"          )] public int playBlockOnce;
		[Serialize("nbPartPlayed"           )] public uint nbPartPlayed;
		[Serialize("startingPart"           )] public uint startingPart;
		[Serialize("partList"               )] public CList<StringID> partList;
		[Serialize("keepPositionBetweenPlay")] public int keepPositionBetweenPlay;
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

