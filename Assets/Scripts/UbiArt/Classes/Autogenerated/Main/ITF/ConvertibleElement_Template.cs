using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ConvertibleElement_Template : CSerializable {
		[Serialize("name"               )] public StringID name;
		[Serialize("animSpiky"          )] public StringID animSpiky;
		[Serialize("animSpikyToFriendly")] public StringID animSpikyToFriendly;
		[Serialize("animFriendly"       )] public StringID animFriendly;
		[Serialize("flip"               )] public bool flip;
		[Serialize("grow"               )] public bool grow;
		[Serialize("delayMin"           )] public float delayMin;
		[Serialize("delayMax"           )] public float delayMax;
		[Serialize("density"            )] public float density;
		[Serialize("fx"                 )] public StringID fx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(animSpiky));
			SerializeField(s, nameof(animSpikyToFriendly));
			SerializeField(s, nameof(animFriendly));
			SerializeField(s, nameof(flip));
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(grow));
				SerializeField(s, nameof(delayMin));
				SerializeField(s, nameof(delayMax));
				SerializeField(s, nameof(density));
			}
			SerializeField(s, nameof(fx));
		}
	}
}

