using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor : Pickable {
		[Serialize("parentBind")] public Nullable<Bind> parentBind;
		[Serialize("COMPONENTS")] public CArray<Generic<ActorComponent>> COMPONENTS;
		[Serialize("LUA"       )] public Path LUA;
		[Serialize("xFLIPPED"  )] public bool xFLIPPED;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(LUA));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(parentBind));
					if (s.HasFlags(SerializeFlags.Persistent)) {
						SerializeField(s, nameof(COMPONENTS));
					}
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(LUA));
					SerializeField(s, nameof(parentBind));
					if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Flags13 | SerializeFlags.Flags14)) {
						SerializeField(s, nameof(COMPONENTS));
					}
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(parentBind));
					if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Flags13 | SerializeFlags.Flags14)) {
						SerializeField(s, nameof(COMPONENTS));
					}
				}
			}
		}
		public override uint? ClassCRC => 0x97CA628B;
	}
}

