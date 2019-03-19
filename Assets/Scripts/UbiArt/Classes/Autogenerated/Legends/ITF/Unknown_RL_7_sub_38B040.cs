using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_7_sub_38B040 : CSerializable {
		[Serialize("name"         )] public StringID name;
		[Serialize("activate"     )] public int activate;
		[Serialize("buslist"      )] public Placeholder buslist;
		[Serialize("factor"       )] public float factor;
		[Serialize("aux"          )] public uint aux;
		[Serialize("reverbParams" )] public Placeholder reverbParams;
		[Serialize("blendDuration")] public float blendDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(buslist));
				SerializeField(s, nameof(factor));
				SerializeField(s, nameof(aux));
				SerializeField(s, nameof(blendDuration));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(buslist));
				SerializeField(s, nameof(factor));
				SerializeField(s, nameof(aux));
				SerializeField(s, nameof(reverbParams));
				SerializeField(s, nameof(blendDuration));
			}
		}
		public override uint? ClassCRC => 0xAC4D988E;
	}
}

