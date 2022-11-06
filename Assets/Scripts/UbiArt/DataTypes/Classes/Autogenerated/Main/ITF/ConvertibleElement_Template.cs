using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class ConvertibleElement_Template : CSerializable {
		public StringID name;
		public StringID animSpiky;
		public StringID animSpikyToFriendly;
		public StringID animFriendly;
		public bool flip;
		public bool grow;
		public float delayMin;
		public float delayMax;
		public float density;
		public StringID fx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			animSpiky = s.SerializeObject<StringID>(animSpiky, name: "animSpiky");
			animSpikyToFriendly = s.SerializeObject<StringID>(animSpikyToFriendly, name: "animSpikyToFriendly");
			animFriendly = s.SerializeObject<StringID>(animFriendly, name: "animFriendly");
			flip = s.Serialize<bool>(flip, name: "flip");
			if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM || s.Settings.game == Settings.Game.VH) {
				grow = s.Serialize<bool>(grow, name: "grow");
				delayMin = s.Serialize<float>(delayMin, name: "delayMin");
				delayMax = s.Serialize<float>(delayMax, name: "delayMax");
				density = s.Serialize<float>(density, name: "density");
			}
			fx = s.SerializeObject<StringID>(fx, name: "fx");
		}
	}
}

