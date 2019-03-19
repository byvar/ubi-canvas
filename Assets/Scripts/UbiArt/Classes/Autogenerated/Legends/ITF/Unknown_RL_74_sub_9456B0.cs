using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_74_sub_9456B0 : CSerializable {
		[Serialize("playBlockOnce"          )] public int playBlockOnce;
		[Serialize("nbPartPlayed"           )] public uint nbPartPlayed;
		[Serialize("startingPart"           )] public uint startingPart;
		[Serialize("partList"               )] public Placeholder partList;
		[Serialize("keepPositionBetweenPlay")] public int keepPositionBetweenPlay;
		[Serialize("pauseInsensitiveFlags"  )] public uint pauseInsensitiveFlags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(pauseInsensitiveFlags));
				SerializeField(s, nameof(playBlockOnce));
				SerializeField(s, nameof(nbPartPlayed));
				SerializeField(s, nameof(startingPart));
				SerializeField(s, nameof(partList));
				SerializeField(s, nameof(keepPositionBetweenPlay));
			} else {
				SerializeField(s, nameof(playBlockOnce));
				SerializeField(s, nameof(nbPartPlayed));
				SerializeField(s, nameof(startingPart));
				SerializeField(s, nameof(partList));
				SerializeField(s, nameof(keepPositionBetweenPlay));
			}
		}
		public override uint? ClassCRC => 0x9AB69974;
	}
}

