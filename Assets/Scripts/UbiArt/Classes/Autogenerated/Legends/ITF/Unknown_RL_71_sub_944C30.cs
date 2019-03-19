using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_71_sub_944C30 : CSerializable {
		[Serialize("startingLeaf"         )] public uint startingLeaf;
		[Serialize("looping"              )] public int looping;
		[Serialize("useIntro"             )] public int useIntro;
		[Serialize("pauseInsensitiveFlags")] public uint pauseInsensitiveFlags;
		[Serialize("looping"              )] public bool looping;
		[Serialize("useIntro"             )] public bool useIntro;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(pauseInsensitiveFlags));
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(looping), boolAsByte: true);
				SerializeField(s, nameof(useIntro), boolAsByte: true);
			} else {
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(useIntro));
				SerializeField(s, nameof(pauseInsensitiveFlags));
			}
		}
		public override uint? ClassCRC => 0xA7DEF63F;
	}
}

